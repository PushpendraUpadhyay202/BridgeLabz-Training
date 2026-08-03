use Healthappdb;

create table patients (
	patient_id int primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	dob date not null,
	gender varchar(10) not null check (gender in ('Male','Female','Other')),
	phone varchar(15) not null unique,
	blood_group varchar(5) check (blood_group in ('A+','A-','B+','B-','AB+','AB-','O+','O-')),
	address varchar(100)

);

create table doctors (
	doctor_id int primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	speciality varchar(50) not null,
	phone varchar(15) not null unique
);

create table appointments (
	appointment_id int primary key identity(1,1),
	patient_id int not null,
	doctor_id int not null,
	appointmentdate date not null,
	appintmenttime time not null,
	status varchar(20) not null default 'Scheduled' check ( status in ('Scheduled' , 'Completed', 'Cancelled' , 'Rescheduled')),


	constraint FK_Appointment_Patient
		foreign key (patient_id)
		references patients(patient_id)
		on delete cascade,

	constraint FK_Appointment_Doctor
		foreign key (doctor_id)
		references doctors(doctor_id)
		on delete cascade
);


create table rooms (
	room_id int primary key identity(1,1),
	room_number varchar(10) not null unique,
	room_type varchar(30) not null,
	floor_no int not null
);

INSERT INTO rooms(room_number, room_type, floor_no)
VALUES
('R101','General',1),
('R102','Orthopedic',1),
('R201','Cardiology',2),
('R202','Emergency',2);


create table doctor_room (
	doctor_id int not null,
	room_id int not null,

	primary key(doctor_id , room_id),

	constraint FK_DoctorRoom_Doctor
		foreign key (doctor_id)
		references doctors(doctor_id)
		on delete cascade,


	constraint FK_DoctorRoom_Room
		foreign key (room_id)
		references rooms(room_id)
		on delete cascade
);


INSERT INTO doctor_room
VALUES
(1,1),
(1,2),
(2,3),
(3,4);


CREATE TABLE Patient_Phones
(
    Phone_ID INT PRIMARY KEY IDENTITY(1,1),

    Patient_ID INT NOT NULL,

    Phone VARCHAR(15) NOT NULL,

    CONSTRAINT FK_PatientPhones
        FOREIGN KEY(Patient_ID)
        REFERENCES patients(Patient_ID)
        ON DELETE CASCADE
);


INSERT INTO Patient_Phones(Patient_ID,Phone)
VALUES
(1,'9876543210'),
(1,'9123456780'),
(2,'9988776655');




-- Rooms Table

CREATE TABLE Rooms
(
    Room_ID INT PRIMARY KEY IDENTITY(1,1),
    Room_Number VARCHAR(10) NOT NULL UNIQUE,
    Room_Type VARCHAR(30) NOT NULL,
    Floor_No INT NOT NULL
);

-- Doctor Room Mapping

CREATE TABLE Doctor_Room
(
    Doctor_ID INT NOT NULL,
    Room_ID INT NOT NULL,

    PRIMARY KEY (Doctor_ID, Room_ID),

    FOREIGN KEY (Doctor_ID)
        REFERENCES Doctors(Doctor_ID)
        ON DELETE CASCADE,

    FOREIGN KEY (Room_ID)
        REFERENCES Rooms(Room_ID)
        ON DELETE CASCADE
);

-- Patient Phones

CREATE TABLE Patient_Phones
(
    Phone_ID INT PRIMARY KEY IDENTITY(1,1),
    Patient_ID INT NOT NULL,
    Phone VARCHAR(15) NOT NULL,

    FOREIGN KEY (Patient_ID)
        REFERENCES Patients(Patient_ID)
        ON DELETE CASCADE
);

-- Single Column Index

CREATE INDEX IX_Appointment_Status
ON Appointments(Status);

-- Composite Index

CREATE INDEX IX_Appointment_PatientDate
ON Appointments(Patient_ID, AppointmentDate);

-- Covering Index

CREATE INDEX IX_Covering_Appointment
ON Appointments(Doctor_ID, AppointmentDate, Status);