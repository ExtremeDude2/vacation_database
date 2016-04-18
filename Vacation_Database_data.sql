USE vacation_database

GO

delete from reservation;
delete from cost;
delete from hotel_room;
delete from reviews;
delete from hotel_location;

insert into hotel_location values ('hotel_0', 'Collegedale', 'USA');
insert into hotel_location values ('hotel_1', 'New York', 'USA');
insert into hotel_location values ('hotel_2', 'Rome', 'Italy');
insert into hotel_location values ('hotel_3', 'Cancun', 'Mexico');
insert into hotel_location values ('hotel_4', 'London', 'England');
insert into hotel_location values ('hotel_5', 'Paris', 'France');

insert into reviews values ('hotel_0', 5, '20160411');
insert into reviews values ('hotel_1', 2, '20150928');
insert into reviews values ('hotel_2', 2, '20150620');
insert into reviews values ('hotel_3', 3, '20150422');
insert into reviews values ('hotel_4', 4, '20150425');
insert into reviews values ('hotel_5', 3, '20150429');

insert into hotel_room values (1337, 'hotel_0', 2);
insert into hotel_room values (1111, 'hotel_1', 3);
insert into hotel_room values (2222, 'hotel_2', 1);
insert into hotel_room values (3333, 'hotel_3', 4);
insert into hotel_room values (4444, 'hotel_4', 1);
insert into hotel_room values (5555, 'hotel_5', 2);

insert into cost values (137, 'USD', 1337, 'hotel_0', '20160511');
insert into cost values (123, 'USD', 1111, 'hotel_1', '20160501');
insert into cost values (231, 'USD', 2222, 'hotel_2', '20160611');
insert into cost values (321, 'USD', 3333, 'hotel_3', '20160510');
insert into cost values (432, 'USD', 4444, 'hotel_4', '20160512');
insert into cost values (543, 'USD', 5555, 'hotel_5', '20160503');

insert into reservation values (1, '20160429', 1337, 'hotel_0');
insert into reservation values (0, '20160428', 1111, 'hotel_1');
insert into reservation values (0, '20160430', 2222, 'hotel_2');
insert into reservation values (0, '20160501', 3333, 'hotel_3');
insert into reservation values (0, '20160511', 4444, 'hotel_4');
insert into reservation values (0, '20160502', 5555, 'hotel_5');

/*
insert into size values (1337, 5);
insert into size values (1111, 2);
insert into size values (2222, 3);
insert into size values (3333, 2);
insert into size values (4444, 1);
insert into size values (5555, 1);
*/
