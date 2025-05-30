CREATE TABLE Movies (
    ID INT PRIMARY KEY IDENTITY,
    Title VARCHAR(255),
    Description TEXT,
    ImagePath VARCHAR(255),
    Rating VARCHAR(10),
    Duration VARCHAR(50),
    Genre VARCHAR(100),

    Price DECIMAL(10,2)
);
