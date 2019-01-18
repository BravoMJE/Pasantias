create database Pasantias
go
use Pasantias
go



---------CREACION DE LAS TABLAS------

create table tblInformeJefe(
idInformeJefe int identity(1,1) not null primary key,
areaAsignada varchar(50) not null,
actividadesDesarrolladas varchar(100) not null,
horario varchar(50) not null, 
fortalezas varchar(50),
debilidades varchar(50),
evaluacion varchar(50) not null,
desempenio varchar(50),
motivacion varchar(50),
contactoTutor bit,
idEmpresa int not null,
idPracticante int not null,
idTutor int not null,
idRegistroDeAsistencia int not null)
go

create table tblSolicitud(
idSolicitud int identity(1,1) not null primary key,
descripcionSolicitud varchar(100) not null,
estadoSolicitud varchar(50) not null,
fechaEmision date not null,
idEmpresa int not null,
idPracticante int not null,
idDecano int not null)
go

create table tblEmpresa(
idEmpresa int identity(1,1) not null primary key,
nombreEmpresa varchar(50) not null,
descripcion varchar(50),
correoElectronico varchar(50) not null,
direccion varchar(50) not null,
telefono varchar(10) not null,
fax varchar(50),
--check (telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
--check (correoElectronico like '%@%')
)
go

create table tblPracticante(
idPracticante int identity(1,1) not null primary key,
fechaNacimiento date not null,
creditosAprobados int not null,
carrera varchar(50) not null,
idUsuario int not null
)
go

create table tblIniformeFinal(
idInformeFinal int identity(1,1) not null primary key,
fechaEmision date not null,
descripcionInforme varchar(100) not null,
materiasUtiles varchar(100),
temasRelevantes varchar(100),
observaciones varchar(100),
idPracticante int not null,
idEmpresa int not null
)
go

create table tblInformeMitadPeriodo(
idInformeMitadPeriodo int identity(1,1) not null primary key, 
preparacionTecnica varchar(100),
capacidadAprendizaje varchar(100),
trabajoEquipo bit not null,
creatividad bit not null,
adaptacion bit not null,
responsabilidad bit not null,
puntualidad bit not null,
idPracticante int not null,
idEmpresa int not null
)
go


create table tblControlTutor(
idControlTutor int identity(1,1) not null primary key, 
fecha date not null,
medio varchar(50) not null,
tema varchar(50),
idInformeMitadPeriodo int not null
)
go


create table tblDecano(
idDecano int identity(1,1) not null primary key,
activo bit not null,
idUsuario int not null
)
go

create table tblTutor(
idTutor int identity(1,1) not null primary key,
departamento varchar(50),
idUsuario int not null
)
go

create table tblJefe(
idJefe int identity(1,1) not null primary key,
idUsuario int not null
)
go

create table tblUsuario(
idUsuario int identity(1,1) not null primary key,
nombreUsuario varchar(50),
login varchar(50),
contrasenia varchar(50),
cedula varchar(10),
telefono varchar(10),
correoElectronico varchar(50)
)
go

create table tblEncuesta(
idEncuesta int identity(1,1) not null primary key,
comentarios varchar(100),
idPracticante int
)
go

create table tblRegistroDeAsistencia(
idRegistroDeAsistencia int identity(1,1) not null primary key,
horasRealizadas float,
fechaFin date,
fechaInicio date,
periodoAcademico varchar(10),
idPracticante int
)
go

create table tblActividad(
idActividad int identity(1,1) not null primary key,
fechaRealizacion date,
horaInicio date,
horaFin date,
numHoras float,
idRegistroAsistencia int
)

create table tblRespuesta(
idRespuesta int identity(1,1) not null primary key,
calificacion int,
idEncuesta int,
idPregunta int
)
go

create table tblPregunta(
idpregunta int identity(1,1) not null primary key,
descripcion varchar(50)
)
go





---------RELACIONES ENTRE TABLAS--------

-----INFORME JEFE - EMPRESA---

alter table tblInformeJefe
add constraint fk_informeJefe_empresa
foreign key (idEmpresa) references tblEmpresa(idEmpresa)
go

-----IFORME JEFE - PRACTICANTE----
alter table tblInformeJefe
add constraint fk_InformeJefe_Practicante
foreign key (idPracticante) references tblPracticante(idPracticante)

---------INFORME JEFE - TUTOR-----
alter table tblInformeJefe
add constraint fk_informeJefe_tutor
foreign key (idTutor) references tblTutor(idTutor)

---------INFORME JEFE - REGISTRO DE ASISTENCIA-------
alter table tblInformeJefe
add constraint fk_InformeJefe_RegistroDeAsistencia
foreign key (idRegistroDeAsistencia) references tblRegistroDeAsistencia(idRegistroDeAsistencia)


---INFORME MITAD DE PERIODO - EMPRESA---
alter table tblInformeMitadPeriodo
add constraint fk_informeMitadPeriodo_Empresa
foreign key (idEmpresa) references tblEmpresa(idEmpresa)


----INFORME MITAD DE PERIODO - PRACTICANTE
alter table tblInformeMitadPeriodo
add constraint fk_informeMitadPeriodo_Practicante
foreign key (idPracticante) references tblPracticante(idPracticante)


----CONTROL TUTOR - INFORME MITAD DE PERIODO---
alter table tblControlTutor
add constraint fk_ControlTutor_InformeMitadDePeriodo
foreign key (idInformeMitadPeriodo) references tblInformeMitadPeriodo(idInformeMitadPeriodo)

----INFORME FINAL - PRACTICANTE---
alter table tblInformeFinal
add constraint fk_InformeFinal_Practicante
foreign key (idPracticante) references tblPracticante(idPracticante)


----INFORME FINAL - EMPRESA---
alter table tblInformeFinal
add constraint fk_InformeFinal_Empresa
foreign key (idEmpresa) references tblEmpresa(idEmpresa)


----PRACTICANTE - USUARIO---
alter table tblPracticante
add constraint fk_Practicante_Usuario
foreign key (idUsuario) references tblUsuario(idUsuario)
