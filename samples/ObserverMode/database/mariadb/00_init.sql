create database if not exists Account;

create table if not exists Account.Member
(
    Id   MEDIUMINT NOT NULL AUTO_INCREMENT,
    Name nvarchar(50)  NOT NULL,
    Content nvarchar(50)  NOT NULL,
    Count int(10)  NOT NULL,
    PRIMARY KEY (Id)
);