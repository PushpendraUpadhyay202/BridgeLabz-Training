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