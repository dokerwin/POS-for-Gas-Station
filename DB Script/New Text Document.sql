

INSERT INTO Person (Name, Surname, IDCard,Sex,Age, Phone1, Phone2, Email1,Email2,Adress_country, Adress_city, Adress_street, Adress_level,Adress_build, Adress_zip, Fax)
VALUES ('Zakhar', 'Kulbachenko', '212121222', 'Male', 26, '533235066',Null, 'zakharkulbachenko@gamil.com', Null ,'Poland', 'Warsaw', 'ZWM', '2','22','02-786','None'   );

INSERT INTO EmPosition (Position, Additional)
VALUES ('Administrator', 'Has full access');

INSERT INTO EmPosition (Position, Additional)
VALUES ('Cashier', 'Has limited access');

INSERT INTO TypeOfEmployment (Type)
VALUES ('Umowa o pracę');

INSERT INTO TypeOfEmployment (Type)
VALUES ('Umowa zlecenia');

INSERT INTO Forecourt (NozzleAmount)
VALUES (4);

INSERT INTO Station (Station_name, ID_Forecourt, Email1, Email2, Adress_country, Adress_city, Adress_street, Adress_build, Adress_zip, Fax, Phone1, Phone2, WWW)
VALUES ('Ursynów-1', 1 , 'ursynow1@gmail.com', Null, 'Polska', 'Warsaw', 'ZWM', '10','02-788', 'None', '+4855235111', null, 'Toras.com.pl');

INSERT INTO Staff (ID_Station, Type_of_staff)
VALUES (1, 'Day');

INSERT INTO Cashier(PESEL, Salary, Hide_date, Fire_date, ID_Type_of_employment, Work_email, Work_phone, ID_Person, IDEmPosition, ID_Staff)
VALUES ('123456789', 2800, '2021-11-11', Null, 2, '123456789@toras.com', '3099099334', 1, 1,1 )
