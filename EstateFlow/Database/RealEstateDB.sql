IF DB_ID(N'RealEstateDB') IS NULL
    CREATE DATABASE RealEstateDB;
GO

USE RealEstateDB;
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
    TypeId      INT NOT NULL FOREIGN KEY REFERENCES dbo.PropertyTypes(Id),
    Area        DECIMAL(10,2) NOT NULL,
    Price       DECIMAL(15,2) NOT NULL,
    Status      NVARCHAR(30)  NOT NULL DEFAULT N'Свободен',
    AgentId     INT NULL FOREIGN KEY REFERENCES dbo.Users(Id),
    CreatedAt   DATETIME NULL DEFAULT GETDATE(),
    Description NVARCHAR(500) NULL
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
    ALTER TABLE dbo.Properties ADD Description NVARCHAR(500) NULL;
GO

-- очистка битой кодировки, если скрипт ранее запускался через консоль без UTF-8
IF EXISTS (SELECT 1 FROM dbo.Showings WHERE Status NOT IN (N'Новая', N'Подтверждена', N'Проведена', N'Отменена'))
   OR EXISTS (SELECT 1 FROM dbo.Properties WHERE Status NOT IN (N'Свободен', N'Забронирован', N'Продан'))
   OR EXISTS (SELECT 1 FROM dbo.Properties WHERE Address LIKE N'%Рі.%')
   OR EXISTS (SELECT 1 FROM dbo.Deals WHERE Status NOT IN (N'В процессе', N'Завершена', N'Отменена'))
BEGIN
    DELETE FROM dbo.Showings;
    DELETE FROM dbo.Deals;
    DELETE FROM dbo.Properties;
    DELETE FROM dbo.PropertyTypes;
    DELETE FROM dbo.Users;
    DELETE FROM dbo.Roles;
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
    INSERT INTO dbo.Properties (Id, Address, TypeId, Area, Price, Status, AgentId, Description) VALUES
    (1,  N'г. Москва, ул. Ленина, д. 10, кв. 5',            1,  54.30,  8500000, N'Забронирован', 2, N'2-комнатная квартира, косметический ремонт'),
    (2,  N'г. Москва, ул. Пушкина, д. 25, кв. 12',          1,  68.70, 11200000, N'Продан',       3, N'3-комнатная квартира в центре'),
    (3,  N'г. Санкт-Петербург, пр. Невский, д. 8',          4, 120.00, 18000000, N'Свободен',     4, N'Офис в бизнес-центре класса B+'),
    (4,  N'г. Казань, ул. Баумана, д. 15, кв. 3',           1,  45.20,  5200000, N'Забронирован', 2, N'1-комнатная квартира у метро'),
    (5,  N'г. Москва, ул. Тверская, д. 7, кв. 22',          1,  89.50, 22000000, N'Забронирован', 5, N'Квартира с видом на Кремль'),
    (6,  N'г. Сочи, ул. Морская, д. 3',                     2, 210.00, 35000000, N'Продан',       2, N'Дом у моря, участок 8 соток'),
    (7,  N'г. Екатеринбург, ул. Мира, д. 40, кв. 8',        1,  62.10,  6800000, N'Забронирован', 3, N'Новостройка, сдача 2026'),
    (8,  N'г. Москва, ул. Арбат, д. 18, кв. 1',             1,  75.00, 19000000, N'Продан',       4, N'Исторический дом'),
    (9,  N'г. Новосибирск, ул. Кирова, д. 12, кв. 7',       1,  50.80,  4900000, N'Свободен',     5, N'2-комнатная квартира'),
    (10, N'г. Москва, Ленинградский пр-т, д. 30',           4,  95.00, 15000000, N'Забронирован', 2, N'Офис открытой планировки'),
    (11, N'г. Краснодар, ул. Красная, д. 5, кв. 14',        1,  58.40,  5500000, N'Продан',       3, N'Квартира с ремонтом'),
    (12, N'г. Москва, ул. Садовая, д. 9, кв. 3',            1,  42.00,  9800000, N'Продан',       4, N'Студия'),
    (13, N'г. Владивосток, ул. Светланская, д. 22',         2, 180.00, 27000000, N'Забронирован', 5, N'Коттедж с гаражом'),
    (14, N'г. Москва, ул. Профсоюзная, д. 55, кв. 9',       1,  66.30, 12500000, N'Забронирован', 2, N'3-комнатная квартира'),
    (15, N'г. Самара, ул. Ново-Садовая, д. 14, кв. 2',      1,  48.90,  4700000, N'Свободен',     3, N'1-комнатная квартира'),
    (16, N'г. Москва, Кутузовский пр-т, д. 20',             4, 110.00, 25000000, N'Забронирован', 4, N'Представительский офис'),
    (17, N'г. Ростов-на-Дону, ул. Большая Садовая, д. 7',   1,  53.70,  5100000, N'Продан',       5, N'2-комнатная квартира'),
    (18, N'г. Москва, ул. Никольская, д. 11, кв. 6',        1,  70.20, 17500000, N'Продан',       2, N'Квартира в пешеходной зоне'),
    (19, N'г. Москва, ул. Профсоюзная, д. 12, комн. 3',     3,  18.50,  3200000, N'Свободен',     16, N'Комната в 3-комнатной квартире'),
    (20, N'г. Казань, ул. Чистопольская, д. 4, гараж 17',   5,  21.00,   900000, N'Свободен',     17, N'Капитальный гараж с ямой');
    SET IDENTITY_INSERT dbo.Properties OFF;
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Deals)
BEGIN
    INSERT INTO dbo.Deals (PropertyId, ClientId, AgentId, DealDate, Amount, Status) VALUES
    (2,  6,  3, '20250115', 11200000, N'Завершена'),
    (6,  7,  2, '20250203', 35000000, N'Завершена'),
    (11, 8,  3, '20250220',  5500000, N'Завершена'),
    (18, 9,  2, '20250305', 17500000, N'Завершена'),
    (1,  10, 2, '20250318',  8500000, N'В процессе'),
    (4,  11, 5, '20250402',  5200000, N'В процессе'),
    (5,  12, 4, '20250415', 22000000, N'В процессе'),
    (7,  13, 3, '20250501',  6800000, N'В процессе'),
    (8,  14, 5, '20250512', 19000000, N'Завершена'),
    (9,  15, 16, '20250525', 4900000, N'Отменена'),
    (10, 18, 2, '20250603', 15000000, N'В процессе'),
    (12, 19, 4, '20250614',  9800000, N'Завершена'),
    (13, 20, 5, '20250628', 27000000, N'В процессе'),
    (14, 6,  2, '20250710', 12500000, N'В процессе'),
    (15, 7,  3, '20250722',  4700000, N'Отменена'),
    (16, 8,  4, '20250805', 25000000, N'В процессе'),
    (17, 9,  5, '20250818',  5100000, N'Завершена'),
    (3,  10, 4, '20250902', 18000000, N'Отменена'),
    (19, 11, 16, '20250915', 3200000, N'Отменена'),
    (20, 12, 17, '20251001',  900000, N'Отменена');
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
