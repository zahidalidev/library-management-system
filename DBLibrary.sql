-- ----------------------------------------------------------------------------
-- DATABASE DBLibrary
-- ----------------------------------------------------------------------------
CREATE DATABASE DBLibrary;

USE DBLibrary
GO
EXEC sp_changedbowner 'sa'

-- ----------------------------------------------------------------------------
-- Table admin
-- ----------------------------------------------------------------------------
CREATE TABLE admin (
  adminID INT NOT NULL IDENTITY,
  username VARCHAR(45) NOT NULL,
  password VARCHAR(45) NOT NULL,
  PRIMARY KEY (adminID)
)

-- ----------------------------------------------------------------------------
-- Table auther
-- ----------------------------------------------------------------------------
CREATE TABLE auther (
  authorID INT NOT NULL IDENTITY,
  fullname VARCHAR(45) NOT NULL,
  PRIMARY KEY (authorID)
)

-- ----------------------------------------------------------------------------
-- Table publisher
-- ----------------------------------------------------------------------------
CREATE TABLE publisher (
  publisherID INT NOT NULL IDENTITY,
  fullname VARCHAR(45) NOT NULL,
  PRIMARY KEY (publisherID)
)


-- ----------------------------------------------------------------------------
-- Table book
-- ----------------------------------------------------------------------------
CREATE TABLE book (
  bookID INT NOT NULL IDENTITY,
  name VARCHAR(45) NOT NULL,
  description VARCHAR(45) NOT NULL,
  genre VARCHAR(45) NOT NULL,
  edition VARCHAR(45) NOT NULL,
  bookImage VARCHAR(45) NOT NULL,
  price VARCHAR(45) NOT NULL,
  totalStock VARCHAR(45) NOT NULL,
  currentStock VARCHAR(45) NOT NULL,
  authorID INT NOT NULL foreign key references auther(authorID),
  publisherID INT NOT NULL foreign key references publisher(publisherID),
  PRIMARY KEY (bookID),
)


-- ----------------------------------------------------------------------------
-- Table member
-- ----------------------------------------------------------------------------
CREATE TABLE member (
  memberID INT NOT NULL IDENTITY,
  password VARCHAR(45) NOT NULL,
  fullname VARCHAR(45) NOT NULL,
  mobileNumber VARCHAR(45) NOT NULL,
  email VARCHAR(45) NOT NULL,
  IDCardNumber VARCHAR(45) NOT NULL,
  PRIMARY KEY (memberID),
)

-- ----------------------------------------------------------------------------
-- Table memberAddress
-- ----------------------------------------------------------------------------
CREATE TABLE memberAddress (
  memberID INT NOT NULL,
  streetAddress VARCHAR(45) NOT NULL,
  city VARCHAR(45) NOT NULL,
  state VARCHAR(45) NOT NULL,
  PRIMARY KEY (memberID),
  FOREIGN KEY (memberID) REFERENCES member(memberID) ON DELETE CASCADE
)


-- ----------------------------------------------------------------------------
-- Table memberbookissue
-- ----------------------------------------------------------------------------
CREATE TABLE memberbookissue (
  memberID INT NOT NULL foreign key references member(memberID),
  bookID INT NOT NULL foreign key references book(bookID)
)

