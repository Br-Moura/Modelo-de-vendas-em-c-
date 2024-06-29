-- trg teste para ver se ja existe
 
IF exists (SELECT 1 from sys.objects WHERE name = 'TRG_ATUALIZAR_STAUTS' AND TYPE = 'TR')
BEGIN
    DROP TRIGGER TRG_ATUALIZAR_STAUTS
  END
GO
-- trg teste para ver se ja existe
 
CREATE TRIGGER TRG_ATUALIZAR_STAUTS_PRODUTO
ON PRODUTO
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @IDPRODUTO INT
	DECLARE @NOME AS VARCHAR(200)
    DECLARE @QTDE AS VARCHAR(50)
    
    SELECT @QTDE = qtdeestoque_produto FROM INSERTED
    SELECT @NOME = nome_produto from INSERTED
    SELECT @IDPRODUTO = id_produto FROM INSERTED
    
    INSERT into alteracaoProduto VALUES (@IDPRODUTO, @NOME,@QTDE, getdate())
END;


