Create DataBase ConsultorioDB
Go
Use ConsultorioDB
Go
Create Table Paciente (
PacienteID int primary key identity,
FechaConsulta Datetime, 
PrimerNombre Nvarchar (50) not null, 
SegundoNombre Nvarchar (50), 
PrimerApellido Nvarchar(50) not null,
SegundoApellido Nvarchar(50), 
Edad int not null, 
Obsevarción Nvarchar (500) not null
);
