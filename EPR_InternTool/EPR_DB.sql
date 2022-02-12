USE `sql10471980` ;

-- -----------------------------------------------------
-- Table `sql10471980`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sql10471980`.`User` (
  `idUser` INT GENERATED ALWAYS AS () VIRTUAL,
  `Nome` VARCHAR(60) NULL,
  `Email` VARCHAR(60) NULL,
  `Login` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  `Endereco` VARCHAR(100) NULL,
  PRIMARY KEY (`idUser`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sql10471980`.`Produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sql10471980`.`Produtos` (
  `CodProdutos` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `Cor` VARCHAR(45) NULL,
  `Produtoscol` VARCHAR(45) NULL,
  `User_idUser` INT NOT NULL,
  PRIMARY KEY (`CodProdutos`),
  INDEX `fk_Produtos_User_idx` (`User_idUser` ASC) VISIBLE,
  CONSTRAINT `fk_Produtos_User`
    FOREIGN KEY (`User_idUser`)
    REFERENCES `sql10471980`.`User` (`idUser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)