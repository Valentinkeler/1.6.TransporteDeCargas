create	database	"113151-Keler-TransporteDeCarga"

create	table	tipoCarga(
codigoTipoCarga	int	identity(1,1),
tipoCarga	varchar(50),
constraint	CodigoTipoCarga	primary	key(codigoTipoCarga))

create	table	carga(
idCarga	int	identity(1,1),
peso	int,
codigoTipoCarga	int,
idCamion	int
constraint	IdCarga	primary	key(idCarga),
constraint	Codigo_Tipo_Carga	foreign	key(codigoTipoCarga)
references	tipoCarga(codigoTipoCarga),
constraint	id_Camion	foreign	key(idCamion)
references	camion(idCamion))

create	table	camion(
idCamion	int	identity(1,1),
patente	varchar(10),
pesoMaximo	int,
estado	bit,
constraint	IdCamion	primary	key(idCamion))

insert	into	tipoCarga(tipoCarga)
values('Packing')
insert	into	tipoCarga(tipoCarga)
values('Cajas')
insert	into	tipoCarga(tipoCarga)
values('Bidones')


create	procedure	pa_consultarTipoCarga
as
	begin	
		select	*	from	tipoCarga
	end

create	procedure	pa_insertarCamion
	@patente	varchar(10),
	@pesoMaximo	int,
	@estado	bit,
	@idCamion	int	output
as	
	begin
		insert into camion(patente,pesoMaximo,estado)
		values(@patente,@pesoMaximo,@estado)
		set	@idCamion	=	SCOPE_IDENTITY()
	end

alter	procedure	pa_insertarCarga
@peso int,
@codigoTipoCarga int,
@idCamion int
as	
	begin
		insert into carga(peso,codigoTipoCarga,idCamion)
		values(@peso,@codigoTipoCarga,@idCamion)
	end


create	procedure	pa_mostrarCamion
as
	begin	
		select	*	from	carga
	end


