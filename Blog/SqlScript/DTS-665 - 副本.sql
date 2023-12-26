-- create table
CREATE TABLE [dbo].[Def_ZipCodeConfig] (
  [Id] INT   NOT NULL  ,
  [CartId] INT   NOT NULL  ,
  [State] NVARCHAR(100)   NOT NULL  ,
  [ZipCodeFrom] INT   NOT NULL  ,
  [ZipCodeTo] INT   NOT NULL  ,
  [Country] NVARCHAR(200) DEFAULT 'US'
)
go

ALTER TABLE [dbo].[ZipCodeConfig] ADD CONSTRAINT [PRIMARY_KEY] PRIMARY KEY ([Id])
go

--insert data 111
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (1,160,'PR',601,795);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (2,160,'NY',501,544);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (3,160,'VI',801,851);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (4,160,'PR',901,988);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (5,160,'MA',1001,2791);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (6,160,'RI',2801,2940);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (7,160,'NH',3031,3897);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (8,160,'ME',3901,4992);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (9,160,'VT',5001,5495);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (10,160,'MA',5501,5544);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (11,160,'VT',5601,5907);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (12,160,'CT',6001,6389);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (13,160,'NY',6390,6390);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (14,160,'CT',6401,6928);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (15,160,'NJ',7001,8989);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (16,160,'AE',9001,9898);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (17,160,'NY',10001,14925);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (18,160,'PA',15001,19640);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (19,160,'DE',19701,19980);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (20,160,'DC',20001,20098);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (21,160,'VA',20101,20199);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (22,160,'DC',20201,20586);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (23,160,'MD',20588,20588);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (24,160,'DC',20590,20597);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (25,160,'VA',20598,20598);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (26,160,'DC',20599,20599);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (27,160,'MD',20601,21930);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (28,160,'VA',22003,24658);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (29,160,'WV',24701,26886);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (30,160,'NC',27006,28909);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (31,160,'SC',29001,29945);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (32,160,'GA',30002,31999);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (33,160,'FL',32003,33994);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (34,160,'AA',34001,34099);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (35,160,'FL',34101,34997);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (36,160,'AL',35004,36925);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (37,160,'TN',37010,38589);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (38,160,'MS',38601,39776);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (39,160,'GA',39813,39901);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (40,160,'KY',40003,42788);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (41,160,'OH',43001,45999);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (42,160,'IN',46001,47997);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (43,160,'MI',48001,49971);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (44,160,'IA',50001,52809);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (45,160,'WI',53001,54990);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (46,160,'MN',55001,56763);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (47,160,'DC',56901,56972);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (48,160,'SD',57001,57799);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (49,160,'ND',58001,58856);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (50,160,'MT',59001,59937);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (51,160,'IL',60001,62999);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (52,160,'MO',63001,65899);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (53,160,'KS',66002,67954);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (54,160,'NE',68001,69367);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (55,160,'LA',70001,71497);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (56,160,'AR',71601,72959);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (57,160,'OK',73001,73199);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (58,160,'TX',73301,73344);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (59,160,'OK',73401,74966);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (60,160,'TX',75001,79999);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (61,160,'CO',80001,81658);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (62,160,'WY',82001,83128);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (63,160,'ID',83201,83406);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (64,160,'WY',83414,83414);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (65,160,'ID',83415,83877);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (66,160,'UT',84001,84791);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (67,160,'AZ',85001,86556);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (68,160,'NM',87001,88439);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (69,160,'TX',88510,88595);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (70,160,'NV',88901,89883);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (71,160,'CA',90001,96162);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (72,160,'AP',96201,96698);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (73,160,'HI',96701,96797);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (74,160,'AS',96799,96799);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (75,160,'HI',96801,96898);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (76,160,'GU',96910,96932);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (77,160,'PW',96939,96940);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (78,160,'FM',96941,96944);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (79,160,'MP',96950,96952);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (80,160,'MH',96960,96970);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (81,160,'OR',97001,97920);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (82,160,'WA',98001,99403);
INSERT INTO Def_ZipCodeConfig ([Id],[CartId],[State],[ZipCodeFrom],[ZipCodeTo]) VALUES (83,160,'AK',99501,99950);