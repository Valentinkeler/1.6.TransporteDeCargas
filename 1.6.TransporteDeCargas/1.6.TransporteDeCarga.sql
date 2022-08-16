create	database	"1.6.TransporteDeCarga"

create	table	tipoCarga(
codigoTipoCarga	int	identity(1,1),
tipoCarga	varchar(50),
constraint	CodigoTipoCarga	primary	key(codigoTipoCarga))

create	table	carga(
idCarga	int	identity(1,1),
peso	int,
codigoTipoCarga	int
constraint	IdCarga	primary	key(idCarga),
constraint	Codigo_Tipo_Carga	foreign	key(codigoTipoCarga)
references	tipoCarga(codigoTipoCarga))

create	table	camion(
patente	varchar(10),
pesoMaximo	int,
estado	bit,
idCarga int
constraint	Patente	primary	key(patente),
constraint	Id_Carga	foreign	key(idCarga)
references	carga(idCarga))

insert	into	tipoCarga(tipoCarga)
values('Packing')
insert	into	tipoCarga(tipoCarga)
values('Cajas')
insert	into	tipoCarga(tipoCarga)
values('Bidones')


create	procedure	consultarTipoCarga
as
	begin	
		select	*	from	tipoCarga
	end

create	procedure	insertarCamion
@patente	varchar(10),
@pesoMaximo	int,
@estado	bit,
@idCarga	int
as	
	begin
		insert into camion(patente,pesoMaximo,estado,idCarga)
		values(@patente,@pesoMaximo,@estado,@idCarga)
	end

create	procedure	insertarCarga
@peso int,
@codigoTipoCarga int
as	
	begin
		insert into carga(peso,codigoTipoCarga)
		values(@peso,@codigoTipoCarga)
	end


create	procedure	mostrarCamion
as
	begin	
		select	*	from	camion
	end