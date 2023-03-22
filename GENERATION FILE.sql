DROP DATABASE IF EXISTS valorantpraccs;

CREATE DATABASE ValorantPraccs;
USE ValorantPraccs;
CREATE TABLE VAL_Maps (
    MapID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    MapName VARCHAR(50) NOT NULL
);

CREATE TABLE VAL_Agents (
    AgentID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    AgentName VARCHAR(50) NOT NULL,
    AgentRole VARCHAR(50) NOT NULL
);

CREATE TABLE VAL_Matches (val_teams
    MatchID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    MapID INT NOT NULL,
    MatchDate DATETIME NOT NULL,
    Winner INT,
    TeamA INT NOT NULL,
    TeamB INT NOT NULL,
    Result VARCHAR(5)
);

CREATE TABLE VAL_Players (
    PlayerID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    PlayerName VARCHAR(50) NOT NULL,
    PlayerRole VARCHAR(50) NOT NULL,
    TeamID INT
);

CREATE TABLE VAL_Teams (
    TeamID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,,
    TeamName VARCHAR(50) NOT NULL
);

---------------------------------------------------
INSERT INTO VAL_Agents (AgentName, AgentRole) VALUES 
('Jett', 'Duelist'),
('Phoenix', 'Duelist'),
('Sage', 'Sentinel'),
('Cypher', 'Controller'),
('Brimstone', 'Controller'),
('Sova', 'Initiator'),
('Reyna', 'Duelist'),
('Killjoy', 'Sentinel'),
('Raze', 'Duelist'),
('Breach', 'Initiator'),
('Viper', 'Controller'),
('Skye', 'Initiator'),
('Omen', 'Controller'),
('Astra', 'Controller'),
('Harbor', 'Initiator'),
('Kay/o', 'Initiator'),
('Chamber', 'Sentinel'),
('Neon', 'Duelist'),
('Gekko', 'Initiator'),
('Fade', 'Initiator'),
('Yoru', 'Duelist');


INSERT INTO VAL_Maps (MapName) VALUES
('Bind'),
('Haven'),
('Split'),
('Ascent'),
('Icebox'),
('Breeze'),
('Fracture'),
('Pearl'),
('Lotus')