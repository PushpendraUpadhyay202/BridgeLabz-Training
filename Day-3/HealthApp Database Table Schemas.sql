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


CREATE TABLE doctor_audit
(
    audit_id INT PRIMARY KEY IDENTITY(1,1),
    doctor_id INT,
    action_performed VARCHAR(20),
    action_date DATETIME DEFAULT GETDATE()
);
ALTER TABLE doctor_audit
ALTER COLUMN action_performed VARCHAR(100);

CREATE TRIGGER trg_Doctor_Insert
ON doctors
AFTER INSERT
AS
BEGIN
    INSERT INTO doctor_audit
    (
        doctor_id,
        action_performed
    )
    SELECT
        doctor_id,
        'Doctor Registered Successfully'
    FROM inserted;
END;


INSERT INTO doctors
(
    firstname,
    lastname,
    speciality,
    phone
)
VALUES
(
    'Rahul',
    'Sharma',
    'Cardiologist',
    '9876543210'
);

select * from doctor_audit;
select * from doctors;

CREATE TRIGGER trg_Doctor_Update
ON doctors
AFTER UPDATE
AS
BEGIN
    INSERT INTO doctor_audit
    (
        doctor_id,
        action_performed
    )
    SELECT
        doctor_id,
        'Doctor Updated'
    FROM inserted;
END;


CREATE TRIGGER trg_Doctor_Delete
ON doctors
AFTER DELETE
AS
BEGIN
    INSERT INTO doctor_audit
    (
        doctor_id,
        action_performed
    )
    SELECT
        doctor_id,
        'Doctor Deleted'
    FROM deleted;
END;



INSERT INTO doctors
(
    firstname,
    lastname,
    speciality,
    phone
)
VALUES
('Amit','Verma','Neurologist','9876543211');

UPDATE doctors
SET speciality = 'General Physician'
WHERE doctor_id = 3;

select * from doctors;

select * from doctor_audit;

DELETE FROM doctors
WHERE doctor_id = 3;



CREATE TABLE patient_audit
(
    audit_id INT PRIMARY KEY IDENTITY(1,1),
    patient_id INT,
    action_performed VARCHAR(50),
    action_date DATETIME DEFAULT GETDATE()
);


CREATE TRIGGER trg_Patient_Insert
ON patients
AFTER INSERT
AS
BEGIN
    INSERT INTO patient_audit
    (
        patient_id,
        action_performed
    )
    SELECT
        patient_id,
        'Patient Registered Successfully'
    FROM inserted;
END;


CREATE TRIGGER trg_Patient_Update
ON patients
AFTER UPDATE
AS
BEGIN
    INSERT INTO patient_audit
    (
        patient_id,
        action_performed
    )
    SELECT
        patient_id,
        'Patient Updated'
    FROM inserted;
END;



CREATE TRIGGER trg_Patient_Delete
ON patients
AFTER DELETE
AS
BEGIN
    INSERT INTO patient_audit
    (
        patient_id,
        action_performed
    )
    SELECT
        patient_id,
        'Patient Deleted'
    FROM deleted;
END;



INSERT INTO patients(
    firstname,
    lastname,
    dob,
    gender,phone,
    blood_group,address
)
VALUES
(
    'Amit',
    'Sharma',
    '1998-05-10',
    'Male',
    '9876543210',
    'A+',
    'Delhi'
);

INSERT INTO patients
(
    firstname,
    lastname,
    dob,
    gender,
    phone,
    blood_group,
    address
)
VALUES
(
    'Priya',
    'Verma',
    '2000-08-15',
    'Female',
    '9876543211',
    'O+',
    'Noida'
);


SELECT * FROM patients;

SELECT * FROM patient_audit;

UPDATE patients
SET blood_group = 'B+'
WHERE patient_id = 1;


SELECT * FROM patient_audit;

DELETE FROM patients
WHERE patient_id = 1;


CREATE TABLE appointment_audit
(
    audit_id INT PRIMARY KEY IDENTITY(1,1),
    appointment_id INT,
    action_performed VARCHAR(50),
    action_date DATETIME DEFAULT GETDATE()
);


CREATE TRIGGER trg_Appointment_Insert
ON appointments
AFTER INSERT
AS
BEGIN
    INSERT INTO appointment_audit
    (
        appointment_id,
        action_performed
    )
    SELECT
        appointment_id,
        'Appointment Created'
    FROM inserted;
END;


CREATE TRIGGER trg_Appointment_Update
ON appointments
AFTER UPDATE
AS
BEGIN
    INSERT INTO appointment_audit
    (
        appointment_id,
        action_performed
    )
    SELECT
        appointment_id,
        'Appointment Updated'
    FROM inserted;
END;



CREATE TRIGGER trg_Appointment_Delete
ON appointments
AFTER DELETE
AS
BEGIN
    INSERT INTO appointment_audit
    (
        appointment_id,
        action_performed
    )
    SELECT
        appointment_id,
        'Appointment Deleted'
    FROM deleted;
END;

select * from patients;
select * from doctors;


INSERT INTO appointments
(
    patient_id,
    doctor_id,
    appointmentdate,
    appintmenttime,
    status
)
VALUES
(
    2,
    4,
    '2026-08-05',
    '10:00:00',
    'Scheduled'
);

INSERT INTO appointments
(
    patient_id,
    doctor_id,
    appointmentdate,
    appintmenttime,
    status
)
VALUES
(
    3,
    5,
    '2026-08-06',
    '11:30:00',
    'Scheduled'
);

UPDATE appointments
SET status = 'Completed'
WHERE appointment_id = 1;

DELETE FROM appointments
WHERE appointment_id = 1;


sp_help appointments;

EXEC sp_rename 'appointments.patiend_id', 'patient_id', 'COLUMN';

select * from appointment_audit;

