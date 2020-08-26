GO
EXEC sp_changedbowner 'sa'



-- ----------------------------------------------------------------------------
-- DATABASE DBLibrary
-- ----------------------------------------------------------------------------
CREATE DATABASE DBLibrary;

USE DBLibrary

-- ----------------------------------------------------------------------------
-- Table admin
-- ----------------------------------------------------------------------------
CREATE TABLE admin (
  adminID INT NOT NULL IDENTITY,
  email VARCHAR(255) NOT NULL UNIQUE,
  password VARCHAR(255) NOT NULL,
  PRIMARY KEY (adminID)
)

-- ----------------------------------------------------------------------------
-- Table auther
-- ----------------------------------------------------------------------------
CREATE TABLE auther (
  authorID INT NOT NULL IDENTITY,
  fullname VARCHAR(255) NOT NULL UNIQUE,
  PRIMARY KEY (authorID)
)

-- ----------------------------------------------------------------------------
-- Table publisher
-- ----------------------------------------------------------------------------
CREATE TABLE publisher (
  publisherID INT NOT NULL IDENTITY,
  fullname VARCHAR(255) NOT NULL UNIQUE,
  PRIMARY KEY (publisherID)
)


-- ----------------------------------------------------------------------------
-- Table book
-- ----------------------------------------------------------------------------
CREATE TABLE book (
  bookID INT NOT NULL IDENTITY,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(555) NOT NULL,
  genre VARCHAR(55) NOT NULL,
  edition VARCHAR(55) NOT NULL,
  bookImage VARCHAR(555) NOT NULL,
  price VARCHAR(155) NOT NULL,
  totalStock VARCHAR(155) NOT NULL,
  currentStock VARCHAR(155) NOT NULL,
  authorID INT NOT NULL foreign key references auther(authorID),
  publisherID INT NOT NULL foreign key references publisher(publisherID),
  PRIMARY KEY (bookID),
)


-- ----------------------------------------------------------------------------
-- Table member
-- ----------------------------------------------------------------------------
CREATE TABLE member (
  memberID INT NOT NULL IDENTITY,
  password VARCHAR(255) NOT NULL,
  fullname VARCHAR(255) NOT NULL,
  mobileNumber VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL UNIQUE,
  IDCardNumber VARCHAR(255) NOT NULL UNIQUE,
  PRIMARY KEY (memberID),
)

-- ----------------------------------------------------------------------------
-- Table memberAddress
-- ----------------------------------------------------------------------------
CREATE TABLE memberAddress (
  memberID INT NOT NULL,
  streetAddress VARCHAR(255) NOT NULL,
  city VARCHAR(155) NOT NULL,
  state VARCHAR(155) NOT NULL,
  PRIMARY KEY (memberID),
  FOREIGN KEY (memberID) REFERENCES member(memberID) ON DELETE CASCADE
)


-- ----------------------------------------------------------------------------
-- Table memberbookissue
-- ----------------------------------------------------------------------------
CREATE TABLE memberbookissue (
  memberID INT NOT NULL foreign key references member(memberID),
  bookID INT NOT NULL foreign key references book(bookID),
  issueData Date NOT NULL,
  dueDate Date NOT NULL
)


