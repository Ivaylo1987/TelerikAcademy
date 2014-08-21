SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema university
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `university` DEFAULT CHARACTER SET utf8 ;
USE `university` ;

-- -----------------------------------------------------
-- Table `university`.`faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`faculties` (
  `FacultyId` INT(11) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`FacultyId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`departments` (
  `DepartmentId` INT(11) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `FacultyId` INT(11) NOT NULL,
  PRIMARY KEY (`DepartmentId`),
  INDEX `fk_Department_Faculties_idx` (`FacultyId` ASC),
  CONSTRAINT `fk_Department_Faculties`
    FOREIGN KEY (`FacultyId`)
    REFERENCES `university`.`faculties` (`FacultyId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`courses` (
  `CoursId` INT(11) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `DepartmentId` INT(11) NOT NULL,
  PRIMARY KEY (`CoursId`),
  INDEX `fk_Courses_Departments1_idx` (`DepartmentId` ASC),
  CONSTRAINT `fk_Courses_Departments1`
    FOREIGN KEY (`DepartmentId`)
    REFERENCES `university`.`departments` (`DepartmentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`professors` (
  `ProfessorId` INT(11) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `DepartmentId` INT(11) NOT NULL,
  PRIMARY KEY (`ProfessorId`),
  INDEX `fk_Professors_Departments1_idx` (`DepartmentId` ASC),
  CONSTRAINT `fk_Professors_Departments1`
    FOREIGN KEY (`DepartmentId`)
    REFERENCES `university`.`departments` (`DepartmentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`titles` (
  `TitleId` INT(11) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`TitleId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`professorstitles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`professorstitles` (
  `ProfessorId` INT(11) NOT NULL,
  `TitleId` INT(11) NOT NULL,
  PRIMARY KEY (`ProfessorId`, `TitleId`),
  INDEX `fk_Professors_has_Titles_Titles1_idx` (`TitleId` ASC),
  INDEX `fk_Professors_has_Titles_Professors1_idx` (`ProfessorId` ASC),
  CONSTRAINT `fk_Professors_has_Titles_Professors1`
    FOREIGN KEY (`ProfessorId`)
    REFERENCES `university`.`professors` (`ProfessorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Professors_has_Titles_Titles1`
    FOREIGN KEY (`TitleId`)
    REFERENCES `university`.`titles` (`TitleId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`students` (
  `StudentId` INT(11) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `FacultyId` INT(11) NOT NULL,
  PRIMARY KEY (`StudentId`),
  INDEX `fk_Students_Faculties1_idx` (`FacultyId` ASC),
  CONSTRAINT `fk_Students_Faculties1`
    FOREIGN KEY (`FacultyId`)
    REFERENCES `university`.`faculties` (`FacultyId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`studentscourses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`studentscourses` (
  `Students_StudentId` INT(11) NOT NULL,
  `Courses_CoursId` INT(11) NOT NULL,
  PRIMARY KEY (`Students_StudentId`, `Courses_CoursId`),
  INDEX `fk_Students_has_Courses_Courses1_idx` (`Courses_CoursId` ASC),
  INDEX `fk_Students_has_Courses_Students1_idx` (`Students_StudentId` ASC),
  CONSTRAINT `fk_Students_has_Courses_Courses1`
    FOREIGN KEY (`Courses_CoursId`)
    REFERENCES `university`.`courses` (`CoursId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Students_has_Courses_Students1`
    FOREIGN KEY (`Students_StudentId`)
    REFERENCES `university`.`students` (`StudentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
