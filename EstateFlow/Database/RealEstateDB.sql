IF DB_ID(N'RealEstateDB') IS NULL
    CREATE DATABASE RealEstateDB;
GO

USE RealEstateDB;
GO

-- владелец sa нужен для построения ER-диаграмм (Database Diagrams) в SSMS
ALTER AUTHORIZATION ON DATABASE::RealEstateDB TO sa;
GO

IF OBJECT_ID(N'dbo.Roles', N'U') IS NULL
CREATE TABLE dbo.Roles
(
    Id   INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users
(
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    Login      NVARCHAR(50)  NOT NULL UNIQUE,
    Password   NVARCHAR(100) NOT NULL,
    Email      NVARCHAR(100) NOT NULL UNIQUE,
    Phone      NVARCHAR(20)  NOT NULL UNIQUE,
    FullName   NVARCHAR(150) NOT NULL,
    RoleId     INT NOT NULL FOREIGN KEY REFERENCES dbo.Roles(Id),
    CreatedAt  DATETIME NULL DEFAULT GETDATE(),
    SecretWord NVARCHAR(100) NULL
);
GO

IF OBJECT_ID(N'dbo.PropertyTypes', N'U') IS NULL
CREATE TABLE dbo.PropertyTypes
(
    Id   INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);
GO

IF OBJECT_ID(N'dbo.Properties', N'U') IS NULL
CREATE TABLE dbo.Properties
(
    Id          INT IDENTITY(1,1) PRIMARY KEY,
    Address     NVARCHAR(200) NOT NULL,
    District    NVARCHAR(100) NULL,
    TypeId      INT NOT NULL FOREIGN KEY REFERENCES dbo.PropertyTypes(Id),
    Rooms       INT NOT NULL DEFAULT 1,
    Floor       INT NULL,
    TotalFloors INT NULL,
    Area        DECIMAL(10,2) NOT NULL,
    KitchenArea DECIMAL(10,2) NULL,
    LivingArea  DECIMAL(10,2) NULL,
    YearBuilt   INT NULL,
    Price       DECIMAL(15,2) NOT NULL,
    Status      NVARCHAR(30)  NOT NULL DEFAULT N'Свободен',
    AgentId     INT NULL FOREIGN KEY REFERENCES dbo.Users(Id),
    CreatedAt   DATETIME NULL DEFAULT GETDATE(),
    Description NVARCHAR(1000) NULL,
    Photo       NVARCHAR(255) NULL
);
GO

IF OBJECT_ID(N'dbo.Deals', N'U') IS NULL
CREATE TABLE dbo.Deals
(
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    PropertyId INT NOT NULL FOREIGN KEY REFERENCES dbo.Properties(Id),
    ClientId   INT NOT NULL FOREIGN KEY REFERENCES dbo.Users(Id),
    AgentId    INT NOT NULL FOREIGN KEY REFERENCES dbo.Users(Id),
    DealDate   DATETIME NOT NULL DEFAULT GETDATE(),
    Amount     DECIMAL(15,2) NOT NULL,
    Status     NVARCHAR(30) NOT NULL DEFAULT N'В процессе'
);
GO

IF OBJECT_ID(N'dbo.Showings', N'U') IS NULL
CREATE TABLE dbo.Showings
(
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    PropertyId INT NOT NULL FOREIGN KEY REFERENCES dbo.Properties(Id),
    ClientId   INT NOT NULL FOREIGN KEY REFERENCES dbo.Users(Id),
    AgentId    INT NULL FOREIGN KEY REFERENCES dbo.Users(Id),
    ShowDate   DATETIME NOT NULL,
    Status     NVARCHAR(30) NOT NULL DEFAULT N'Новая',
    Comment    NVARCHAR(300) NULL,
    CreatedAt  DATETIME NOT NULL DEFAULT GETDATE()
);
GO

IF COL_LENGTH(N'dbo.Users', N'SecretWord') IS NULL
    ALTER TABLE dbo.Users ADD SecretWord NVARCHAR(100) NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'Description') IS NULL
    ALTER TABLE dbo.Properties ADD Description NVARCHAR(1000) NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'District') IS NULL
    ALTER TABLE dbo.Properties ADD District NVARCHAR(100) NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'Rooms') IS NULL
    ALTER TABLE dbo.Properties ADD Rooms INT NOT NULL DEFAULT 1;
GO
IF COL_LENGTH(N'dbo.Properties', N'Floor') IS NULL
    ALTER TABLE dbo.Properties ADD Floor INT NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'TotalFloors') IS NULL
    ALTER TABLE dbo.Properties ADD TotalFloors INT NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'KitchenArea') IS NULL
    ALTER TABLE dbo.Properties ADD KitchenArea DECIMAL(10,2) NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'LivingArea') IS NULL
    ALTER TABLE dbo.Properties ADD LivingArea DECIMAL(10,2) NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'YearBuilt') IS NULL
    ALTER TABLE dbo.Properties ADD YearBuilt INT NULL;
GO
IF COL_LENGTH(N'dbo.Properties', N'Photo') IS NULL
    ALTER TABLE dbo.Properties ADD Photo NVARCHAR(255) NULL;
GO

-- миграция старых тестовых данных (Москва, Питер и т.д.) на Благовещенск
IF EXISTS (SELECT 1 FROM dbo.Properties WHERE Address LIKE N'%Москва%' OR Address NOT LIKE N'%Благовещенск%')
   OR EXISTS (SELECT 1 FROM dbo.Properties WHERE Photo IS NULL)
   OR EXISTS (SELECT 1 FROM dbo.Showings WHERE Status NOT IN (N'Новая', N'Подтверждена', N'Проведена', N'Отменена'))
BEGIN
    DELETE FROM dbo.Showings;
    DELETE FROM dbo.Deals;
    DELETE FROM dbo.Properties;
    DBCC CHECKIDENT ('dbo.Properties', RESEED, 0);
    DBCC CHECKIDENT ('dbo.Showings', RESEED, 0);
    DBCC CHECKIDENT ('dbo.Deals', RESEED, 0);
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Roles)
BEGIN
    SET IDENTITY_INSERT dbo.Roles ON;
    INSERT INTO dbo.Roles (Id, Name) VALUES
    (1, N'Администратор'), (2, N'Агент'), (3, N'Клиент');
    SET IDENTITY_INSERT dbo.Roles OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.PropertyTypes)
BEGIN
    SET IDENTITY_INSERT dbo.PropertyTypes ON;
    INSERT INTO dbo.PropertyTypes (Id, Name) VALUES
    (1, N'Квартира'), (2, N'Дом'), (3, N'Комната'), (4, N'Офис'), (5, N'Гараж');
    SET IDENTITY_INSERT dbo.PropertyTypes OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Users)
BEGIN
    SET IDENTITY_INSERT dbo.Users ON;
    INSERT INTO dbo.Users (Id, Login, Password, Email, Phone, FullName, RoleId, SecretWord) VALUES
    (1,  N'admin',    N'Admin1234567!', N'i.ivanov@realestate.ru',    N'+7(916)234-56-78', N'Иванов Иван Иванович',        1, N'недвижимость'),
    (2,  N'agent01',  N'Agent1234567!', N'p.petrov@realestate.ru',    N'+7(925)345-67-89', N'Петров Пётр Петрович',        2, N'недвижимость'),
    (3,  N'agent02',  N'Agent1234568!', N'a.sidorova@realestate.ru',  N'+7(903)456-78-90', N'Сидорова Анна Сергеевна',     2, N'недвижимость'),
    (4,  N'agent03',  N'Agent1234569!', N'd.kuznetsov@realestate.ru', N'+7(926)567-89-01', N'Кузнецов Дмитрий Олегович',   2, N'недвижимость'),
    (5,  N'agent04',  N'Agent1234570!', N'o.smirnova@realestate.ru',  N'+7(909)678-90-12', N'Смирнова Ольга Ивановна',     2, N'недвижимость'),
    (6,  N'morozov',  N'Client123456!', N'a.morozov@gmail.com',       N'+7(917)789-01-23', N'Морозов Алексей Викторович',  3, N'недвижимость'),
    (7,  N'volkova',  N'Client123457!', N'm.volkova@yandex.ru',       N'+7(999)890-12-34', N'Волкова Мария Андреевна',     3, N'недвижимость'),
    (8,  N'zaytsev',  N'Client123458!', N'n.zaytsev@gmail.com',       N'+7(915)901-23-45', N'Зайцев Никита Павлович',      3, N'недвижимость'),
    (9,  N'lebedeva', N'Client123459!', N'e.lebedeva@bk.ru',          N'+7(968)012-34-56', N'Лебедева Екатерина Игоревна', 3, N'недвижимость'),
    (10, N'sokolov',  N'Client123460!', N'a.sokolov@yandex.ru',       N'+7(985)123-45-67', N'Соколов Артём Денисович',     3, N'недвижимость'),
    (11, N'pavlova',  N'Client123461!', N'd.pavlova@gmail.com',       N'+7(977)234-56-78', N'Павлова Дарья Романовна',     3, N'недвижимость'),
    (12, N'golubev',  N'Client123462!', N'e.golubev@inbox.ru',        N'+7(962)345-67-89', N'Голубев Егор Максимович',     3, N'недвижимость'),
    (13, N'titova',   N'Client123463!', N'p.titova@yandex.ru',        N'+7(936)456-78-90', N'Титова Полина Артёмовна',     3, N'недвижимость'),
    (14, N'fedorov',  N'Client123464!', N'k.fedorov@gmail.com',       N'+7(910)567-89-01', N'Фёдоров Кирилл Иванович',     3, N'недвижимость'),
    (15, N'egorova',  N'Client123465!', N's.egorova@list.ru',         N'+7(924)678-90-12', N'Егорова София Максимовна',    3, N'недвижимость'),
    (16, N'agent05',  N'Agent1234571!', N'v.nikolaev@realestate.ru',  N'+7(929)789-01-23', N'Николаев Владислав Петрович', 2, N'недвижимость'),
    (17, N'agent06',  N'Agent1234572!', N'v.andreeva@realestate.ru',  N'+7(921)890-12-34', N'Андреева Виктория Олеговна',  2, N'недвижимость'),
    (18, N'romanov',  N'Client123466!', N'm.romanov@gmail.com',       N'+7(988)901-23-45', N'Романов Максим Сергеевич',    3, N'недвижимость'),
    (19, N'belova',   N'Client123467!', N'a.belova@yandex.ru',        N'+7(950)012-34-56', N'Белова Алиса Дмитриевна',     3, N'недвижимость'),
    (20, N'orlov',    N'Client123468!', N't.orlov@bk.ru',             N'+7(996)123-45-67', N'Орлов Тимофей Андреевич',     3, N'недвижимость');
    SET IDENTITY_INSERT dbo.Users OFF;
END
GO

UPDATE dbo.Users SET SecretWord = N'недвижимость' WHERE SecretWord IS NULL;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Properties)
BEGIN
    SET IDENTITY_INSERT dbo.Properties ON;
    INSERT INTO dbo.Properties (Id, Address, District, TypeId, Rooms, Floor, TotalFloors, Area, KitchenArea, LivingArea, YearBuilt, Price, Status, AgentId, Description, Photo) VALUES
    (1,  N'г. Благовещенск, ул. Ленина, д. 148, кв. 24',        N'Центр',       1, 2,  5,  9,  58.40, 11.20, 34.00, 2018,  8900000, N'Забронирован', 2, N'Светлая 2-комнатная квартира с качественным евроремонтом в самом сердце Благовещенска. Окна на набережную реки Амур. Закрытый двор, подземный паркинг.', N'prop_1.jpg'),
    (2,  N'г. Благовещенск, ул. Амурская, д. 115, кв. 38',      N'Центр',       1, 3,  7, 14,  82.50, 14.50, 48.00, 2021, 13400000, N'Продан',       3, N'Просторная 3-комнатная квартира в новом монолитно-кирпичном доме ЖК «Амурский». Раздельный санузел, две застекленные лоджии, панорамные виды на Китай.', N'prop_2.jpg'),
    (3,  N'г. Благовещенск, ул. Калинина, д. 88, кв. 14',       N'Центр',       1, 1,  3, 10,  41.20, 10.00, 19.50, 2019,  6350000, N'Свободен',     4, N'1-комнатная квартира с дизайнерским ремонтом. Встроенная кухня с техникой, мебель остаётся. Рядом Амурский госуниверситет и набережная.', N'prop_3.jpg'),
    (4,  N'г. Благовещенск, Игнатьевское шоссе, д. 14/1, кв. 72', N'Микрорайон', 1, 0,  8, 16,  28.60,  5.00, 18.00, 2022,  4950000, N'Забронирован', 5, N'Уютная видовая студия в современном ЖК в микрорайоне. Идеально под сдачу в аренду или для студента АмГУ. Низкие коммунальные платежи.', N'prop_4.jpg'),
    (5,  N'г. Благовещенск, ул. Горького, д. 172, кв. 55',      N'Центр',       1, 2,  4,  9,  64.00, 12.00, 36.00, 2020,  9700000, N'Забронирован', 2, N'Просторная двухкомнатная квартира распашонка с отличным ремонтом. Рядом школа №14, детские сады, супермаркеты.', N'prop_5.jpg'),
    (6,  N'г. Благовещенск, ул. Набережная, д. 22',             N'Золотая миля', 2, 5,  2,  2, 240.00, 22.00, 140.0, 2021, 28500000, N'Продан',       3, N'Элитный коттедж на берегу Амура. Центральные коммуникации, гараж на 2 авто, ландшафтный дизайн, сауна, терраса с видом на закаты над рекой.', N'prop_6.jpg'),
    (7,  N'г. Благовещенск, ул. Дьяченко, д. 6, кв. 19',        N'Микрорайон',  1, 3,  6, 10,  76.80, 13.00, 45.00, 2017, 10900000, N'Забронирован', 4, N'Отличная семейная 3-комнатная квартира во 2-м микрорайоне. Развитая инфраструктура: парк Дружбы, кинотеатр, бассейн «Надежда».', N'prop_7.jpg'),
    (8,  N'г. Благовещенск, ул. Зейская, д. 210, кв. 41',       N'Центр',       1, 1,  2,  5,  36.50,  8.50, 18.00, 2012,  5400000, N'Продан',       5, N'Уютная однушка в тихом зеленом центре. Кирпичный теплый дом, чистый подъезд, доброжелательные соседи. Без обременений.', N'prop_8.jpg'),
    (9,  N'г. Благовещенск, ул. Кантемирова, д. 18, кв. 83',     N'Микрорайон',  1, 2,  9, 10,  55.00, 10.50, 31.00, 2016,  7800000, N'Свободен',    16, N'Квартира с изолированными комнатами. Красивый панорамный вид из окон. В шаговой доступности ТРЦ «Острова» и Амурский колледж.', N'prop_9.jpg'),
    (10, N'г. Благовещенск, ул. 50 лет Октября, д. 28',         N'Центр',       4, 3,  2,  4,  95.00,   NULL,  70.00, 2015, 14500000, N'Забронирован', 17, N'Коммерческое помещение свободного назначения на первой линии. Высокий пешеходный трафик, отдельный вход, охрана, парковка.', N'prop_10.jpg'),
    (11, N'г. Благовещенск, ул. Театральная, д. 79, кв. 12',     N'Северный',    1, 2,  4,  5,  49.00,  7.50, 29.00, 2010,  6100000, N'Продан',       2, N'2-комнатная квартира улучшенной планировки. Балкон остеклен, с/у в кафеле. Отличная транспортная доступность.', N'prop_11.jpg'),
    (12, N'г. Благовещенск, ул. Василенко, д. 11, кв. 64',      N'Тепличный',   1, 0, 11, 14,  26.20,  5.00, 17.00, 2023,  4650000, N'Продан',       3, N'Свежая студия в новом доме комфорт-класса. Свежий ремонт, натяжные потолки, новая сантехника. Рядом новая современная школа.', N'prop_12.jpg'),
    (13, N'г. Благовещенск, ул. Пионерская, д. 45, кв. 7',      N'Центр',       1, 4,  3,  6, 118.00, 18.00, 72.00, 2019, 18900000, N'Забронирован', 4, N'Роскошная 4-комнатная квартира с мастер-спальней, гардеробной и сауной. Закрытая охраняемая территория, видеонаблюдение.', N'prop_13.jpg'),
    (14, N'г. Благовещенск, ул. Шевченко, д. 80, кв. 29',       N'Центр',       1, 1,  5,  9,  44.50, 11.50, 20.00, 2021,  6900000, N'Забронирован', 5, N'Стильная евродвушка с большой кухней-гостиной. Автономное отопление, теплые полы, благоустроенный двор с детской площадкой.', N'prop_14.jpg'),
    (15, N'г. Благовещенск, ул. Воронкова, д. 15/2, кв. 90',    N'Европейский', 1, 2,  8, 16,  61.30, 13.00, 33.00, 2022,  8650000, N'Свободен',     3, N'Новая квартира в популярном микрорайоне «Европейский». Качественная предчистовая отделка, горизонтальная разводка отопления.', N'prop_15.jpg'),
    (16, N'г. Благовещенск, ул. Артиллерийская, д. 31, кв. 5',  N'Центр',       3, 1,  2,  3,  18.00,  4.00, 14.00, 2008,  2450000, N'Забронирован', 16, N'Уютная комната в малонаселенной секции. Свой счетчик, пластиковое окно, свежие обои. Подходит под ипотеку и маткапитал.', N'prop_16.jpg'),
    (17, N'г. Благовещенск, ул. Мухина, д. 110, кв. 42',        N'КПП',         1, 2,  3,  5,  52.00,  9.00, 30.00, 2011,  6400000, N'Продан',        2, N'Ухоженная 2-комнатная квартира в районе КПП. Рядом торговые центры, школа, остановки во все концы города.', N'prop_17.jpg'),
    (18, N'г. Благовещенск, пос. Чигири, ул. Европейская, д. 8', N'Чигири',      2, 4,  1,  1, 135.00, 16.00, 80.00, 2023, 11800000, N'Продан',       3, N'Новый одноэтажный кирпичный коттедж с предчистовой отделкой. Септик, скважина, электрический котел, теплые полы по всему дому.', N'prop_18.jpg'),
    (19, N'г. Благовещенск, ул. Политехническая, д. 144, кв. 18', N'Центр',     1, 3,  5, 10,  88.00, 15.00, 51.00, 2020, 13900000, N'Свободен',     4, N'Эксклюзивная 3-комнатная квартира с дорогостоящей отделкой. Панорамные окна на две стороны, встроенная техника европейских брендов.', N'prop_19.jpg'),
    (20, N'г. Благовещенск, ул. Загородная, д. 53, бокс 12',    N'КПП',         5, 1,  1,  1,  24.00,   NULL,  24.00, 2018,  1150000, N'Свободен',     5, N'Капитальный гараж в ГСК. Железобетонные перекрытия, смотровая яма, свет, вентиляция, металлические ворота с утеплением.', N'prop_20.jpg');
    SET IDENTITY_INSERT dbo.Properties OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Deals)
BEGIN
    INSERT INTO dbo.Deals (PropertyId, ClientId, AgentId, DealDate, Amount, Status) VALUES
    (2,  6,  3, '20250115', 13400000, N'Завершена'),
    (6,  7,  3, '20250203', 28500000, N'Завершена'),
    (8,  8,  5, '20250220',  5400000, N'Завершена'),
    (11, 9,  2, '20250305',  6100000, N'Завершена'),
    (12, 10, 3, '20250318',  4650000, N'Завершена'),
    (17, 11, 2, '20250402',  6400000, N'Завершена'),
    (18, 12, 3, '20250415', 11800000, N'Завершена'),
    (1,  13, 2, '20250501',  8900000, N'В процессе'),
    (4,  14, 5, '20250512',  4950000, N'В процессе'),
    (5,  15, 2, '20250525',  9700000, N'В процессе'),
    (7,  18, 4, '20250603', 10900000, N'В процессе'),
    (10, 19, 17, '20250614', 14500000, N'В процессе'),
    (13, 20, 4, '20250628', 18900000, N'В процессе'),
    (14, 6,  5, '20250710',  6900000, N'В процессе'),
    (16, 7,  16, '20250722',  2450000, N'В процессе'),
    (3,  8,  4, '20250805',  6350000, N'Отменена'),
    (9,  9,  16, '20250818',  7800000, N'Отменена'),
    (15, 10, 3, '20250902',  8650000, N'Отменена'),
    (19, 11, 4, '20250915', 13900000, N'Отменена'),
    (20, 12, 5, '20251001',  1150000, N'Отменена');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Showings)
BEGIN
    INSERT INTO dbo.Showings (PropertyId, ClientId, AgentId, ShowDate, Status, Comment) VALUES
    (3,  6,  4, '20251110 11:00', N'Проведена',    N'Клиенту понравилась планировка'),
    (9,  7,  5, '20251112 15:30', N'Проведена',    NULL),
    (15, 8,  3, '20251114 10:00', N'Отменена',     N'Клиент перенёс поиск'),
    (19, 9,  16, '20251118 12:00', N'Проведена',   NULL),
    (20, 10, 17, '20251120 17:00', N'Проведена',   N'Требуется осмотр документов'),
    (3,  11, 4, '20251122 14:00', N'Подтверждена', NULL),
    (9,  12, 5, '20251125 16:00', N'Подтверждена', N'Взять ключи у собственника'),
    (15, 13, 3, '20251127 11:30', N'Новая',        NULL),
    (19, 14, 16, '20251128 13:00', N'Новая',       NULL),
    (20, 15, 17, '20251201 10:30', N'Новая',       N'Позвонить за час'),
    (3,  18, 4, '20251202 12:30', N'Новая',        NULL),
    (9,  19, 5, '20251203 18:00', N'Новая',        NULL),
    (15, 20, 3, '20251204 09:30', N'Подтверждена', NULL),
    (1,  10, 2, '20250310 11:00', N'Проведена',    N'Перед сделкой'),
    (4,  11, 5, '20250325 15:00', N'Проведена',    N'Перед сделкой'),
    (5,  12, 4, '20250410 12:00', N'Проведена',    NULL),
    (7,  13, 3, '20250425 16:30', N'Проведена',    NULL),
    (10, 18, 2, '20250528 10:00', N'Проведена',    NULL),
    (13, 20, 5, '20250620 14:00', N'Проведена',    NULL),
    (14, 6,  2, '20250702 17:30', N'Проведена',    NULL);
END
GO

-- синхронизация статусов объектов со сделками
UPDATE p
SET p.Status = CASE
    WHEN EXISTS (SELECT 1 FROM dbo.Deals d WHERE d.PropertyId = p.Id AND d.Status = N'Завершена') THEN N'Продан'
    WHEN EXISTS (SELECT 1 FROM dbo.Deals d WHERE d.PropertyId = p.Id AND d.Status = N'В процессе') THEN N'Забронирован'
    ELSE N'Свободен'
END
FROM dbo.Properties p;
GO
