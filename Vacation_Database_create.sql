-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2016-04-12 20:32:58.29

-- tables
-- Table: cost
CREATE TABLE cost (
    price int  NOT NULL,
    currency varchar(127)  NOT NULL,
    room_num int  NOT NULL,
    hotel_name varchar(127)  NOT NULL,
    till_date varchar(21)  NOT NULL,
    CONSTRAINT cost_pk PRIMARY KEY  (room_num)
);

-- Table: hotel_location
CREATE TABLE hotel_location (
    hotel_name varchar(127)  NOT NULL,
    city varchar(127)  NOT NULL,
    country varchar(127)  NOT NULL,
    CONSTRAINT hotel_location_pk PRIMARY KEY  (hotel_name)
);

-- Table: hotel_room
CREATE TABLE hotel_room (
    room_num int  NOT NULL,
    hotel_name varchar(127)  NOT NULL,
    num_beds int  NOT NULL,
    CONSTRAINT hotel_room_pk PRIMARY KEY  (room_num,hotel_name)
);

-- Table: reservation
CREATE TABLE reservation (
    "current" int  NOT NULL,
    next_date_available char(21)  NOT NULL,
    room_num int  NOT NULL,
    hotel_name varchar(127)  NOT NULL,
    CONSTRAINT reservation_pk PRIMARY KEY  (room_num)
);

-- Table: reviews
CREATE TABLE reviews (
    hotel_name varchar(127)  NOT NULL,
    rating int  NOT NULL,
    review_date char(21)  NOT NULL,
    CONSTRAINT reviews_pk PRIMARY KEY  (hotel_name)
);

-- foreign keys
-- Reference: cost_hotel_room (table: cost)
ALTER TABLE cost ADD CONSTRAINT cost_hotel_room 
    FOREIGN KEY (room_num,hotel_name)
    REFERENCES hotel_room (room_num,hotel_name);

-- Reference: hotel_room_location (table: hotel_room)
ALTER TABLE hotel_room ADD CONSTRAINT hotel_room_location 
    FOREIGN KEY (hotel_name)
    REFERENCES hotel_location (hotel_name);

-- Reference: reservation_hotel_room (table: reservation)
ALTER TABLE reservation ADD CONSTRAINT reservation_hotel_room 
    FOREIGN KEY (room_num,hotel_name)
    REFERENCES hotel_room (room_num,hotel_name);

-- Reference: reviews_location (table: reviews)
ALTER TABLE reviews ADD CONSTRAINT reviews_location 
    FOREIGN KEY (hotel_name)
    REFERENCES hotel_location (hotel_name);

-- End of file.

