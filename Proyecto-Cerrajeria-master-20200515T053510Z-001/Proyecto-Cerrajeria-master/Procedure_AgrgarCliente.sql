CREATE PROCEDURE sp_Cliente
(
	@Nom VARCHAR(60),
	@Rfc VARCHAR(13),
	@Dire VARCHAR(80), 
	@Cod VARCHAR(5),
	@Ciu VARCHAR(80),
	@Tel VARCHAR(10), 
	@Col VARCHAR(40)) as 

  Begin tran
    Begin try
     INSERT INTO Clientes(Nombre, RFC, Direccion, Cod_Post, Ciudad, Telefono, Colonia)

     values
	 (	@Nom, 
		@Rfc, 
		@Dire, 
		@Cod, 
		@Ciu,
		@Tel, 
		@Col
	 )
      COMMIT
    END TRY
  BEGIN CATCH
	 ROLLBACK
	 RAISERROR('No se pudo ingresar los datos de forma correcta',16,1)
  END CATCH
  GO

  Select* FROM Clientes