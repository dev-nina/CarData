CREATE SCHEMA `Carservice` ;

CREATE TABLE `Carservice`.`Client` (
  `IdClient` INT NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(45) NOT NULL,
  `SecondName` VARCHAR(45) NOT NULL,
 `ThirdName` VARCHAR(45) NOT NULL, `Birth` INT NOT NULL,
  `Phone` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`IdClient`));

CREATE TABLE `Carservice`.`Car` (
  `IdCar` INT NOT NULL AUTO_INCREMENT,
  `Mark` VARCHAR(45) NOT NULL,
  `Model` VARCHAR(45) NOT NULL,
  `Year` INT NOT NULL,
  `Transmission` VARCHAR(45) NOT NULL,
  `Horsepower` FLOAT NOT NULL,
  `ClientId` INT NOT NULL,
  PRIMARY KEY (`IdCar`),
  FOREIGN KEY (`ClientId`) REFERENCES `Carservice`.`Client`(IdClient));

CREATE TABLE `Carservice`.`Order` (
  `IdOrder` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(45) NOT NULL,
  `BeginTime` DATETIME NOT NULL,
  `EndTime` DATETIME,
  `Cost` FLOAT NOT NULL,
  `CarId` INT NOT NULL,
  PRIMARY KEY (`idOrder`),
  FOREIGN KEY (`CarId`) REFERENCES `Carservice`.`Car`(IdCar));

INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`, `Birth`, `Phone`) VALUES ('1', 'Смирнов', 'Дмитрий', 'Павлович', '1980', '89001568956');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('2', 'Михайлова', 'Анна', 'Станиславовна','1988', '89502589636');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('3', 'Новиков', 'Анатолий', 'Михайлович','1993', '89525896321');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('4', 'Фёдоров', 'Сергей', 'Викторович','1991', '89502589641');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('5', 'Кондрашова', 'Елизавета', 'Михайловна','1995', '89520365478');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('6', 'Руденко', 'Андрей', 'Николаевич','1993', '803285244779');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('7', 'Никонов', 'Сергей', 'Олегович','1975', '89505214786');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('8', 'Андрусенко', 'Алла', 'Станиславовна','1988', '89508473256');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('9', 'Хаустов', 'Евгений', 'Михайлович','1970', '89524185269');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('10', 'Семенов', 'Геннадий', 'Викторович','1991', '89587415693');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('11', 'Жигулина', 'Елена', 'Ивановна','1986', '89062478569');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('12', 'Дьяченко', 'Анатолий', 'Романович','1992', '89525289647');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('13', 'Антипов', 'Святослав', 'Павлович','1990', '89502589641');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('14', 'Орлов', 'Дмитрий', 'Дмитриевич','1989', '89541234789');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('15', 'Сидоренко', 'Олег', 'Михайлович','1993', '89005895247');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('16', 'Потапов', 'Александр', 'Сергеевич','1974', '89506485279');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('17', 'Протасова', 'Виолетта', 'Петровна','1976', '89552148563');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('18', 'Джураев', 'Виктор', 'Данилович','1984', '89525471256');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('19', 'Ларин', 'Павел', 'Валентинович','1991', '89004715896');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('20', 'Тарасова', 'Ольга', 'Борисовна','1975', '89502541896');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('21', 'Шипулин', 'Антон', 'Владимирович','1980', '89054825896');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('22', 'Фёдоров', 'Сергей', 'Викторович','1991', '89052589641');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('23', 'Ильина', 'Инна', 'Кирилловна','1996', '89502589636');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('24', 'Соврасов', 'Петр', 'Иванович','1969', '89085478963');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('25', 'Никонов', 'Иван', 'Иванович','1991', '89065478592');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('26', 'Бортич', 'Ирина', 'Дмитриевна','1978', '89005478269');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('27', 'Соврасов', 'Матвей', 'Михайлович','1983', '89065814758');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('28', 'Антонов', 'Роман', 'Викторович','1990', '89051478596');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('29', 'Мамонов', 'Евгений', 'Романович','1976', '89502589636');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('30', 'Марков', 'Леонид', 'Петрович','1993', '89008541278');
INSERT INTO `Carservice`.`Client` (`IdClient`, `FirstName`, `SecondName`, `ThirdName`,`Birth`, `Phone`) VALUES ('31', 'Долина', 'Валентина', 'Семеновна','1985', '89504781596');

INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('1', 'Land Rover', 'Discovery', '2011', 'Автоматическая', '3.0', '1');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('2', 'Volkswagen', 'Jetta', '2013', 'Автоматическая', '1.6', '2');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('3', 'Toyota', 'Venza', '2012', 'Автоматическая', '2.7', '3');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('4', 'Ford', 'Focus', '2014', 'Механическая', '1.6', '4');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('5', 'Lada', 'Granta', '2010', 'Автоматическая', '1.0', '5');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('6', 'Renault', 'Duster', '2007', 'Автоматическая', '1.6', '5');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('7', 'Lada', '4x4', '2012', 'Механическая', '2.7', '6');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('8', 'Chevrolet', 'Niva', '2007', 'Механическая', '1.6', '7');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('9', 'Toyota', 'RAV4', '2011', 'Автоматическая', '3.0', '8');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('10', 'Hyundai', 'ix35', '2010', 'Автоматическая', '2.6', '9');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('11', 'Nissan', 'Qashqai', '2012', 'Автоматическая', '2.7', '10');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('12', 'KIA', 'Sportage', '2005', 'Автоматическая', '1.6', '11');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('13', 'Mitsubishi', 'Outlander', '2011', 'Автоматическая', '3.0', '12');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('14', 'Nissan', 'X-Trail', '2013', 'Автоматическая', '1.6', '13');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('15', 'Volkswagen ', 'Tiguan', '2012', 'Автоматическая', '2.7', '14');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('16', 'Hyundai', 'Solaris', '2014', 'Механическая', '1.6', '15');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('17', 'KIA', 'Rio', '2011', 'Автоматическая', '3.0', '16');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('18', 'Lada', 'Kalina', '2013', 'Механическая', '2.6', '17');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('19', 'Lada', 'Largus', '2012', 'Механическая', '2.7', '18');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('20', 'Renault', 'Logan', '2014', 'Механическая', '1.6', '19');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('21', 'Lada', 'Priora', '2006', 'Автоматическая', '3.0', '20');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('22', 'Volkswagen', 'Polo', '2013', 'Автоматическая', '2.6', '21');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('23', 'Nissan', 'Almera', '2016', 'Автоматическая', '2.7', '22');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('24', 'Skoda', 'Octavia', '2014', 'Механическая', '1.6', '23');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('25', 'Honda', 'Jazz', '2012', 'Автоматическая', '2.7', '24');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('26', 'Ford', 'Mondeo', '2017', 'Механическая', '1.6', '25');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('27', 'Ram', 'Pickup', '2011', 'Автоматическая', '3.0', '15');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('28', 'Volkswagen', 'Lavida', '2013', 'Автоматическая', '1.6', '26');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('29', 'Hyundai', 'Elantra', '2012', 'Автоматическая', '2.7', '27');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('30', 'Chevrolet', 'Silverado', '2014', 'Автоматическая', '1.6', '28');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('31', 'Toyotar', 'Camry', '2017', 'Автоматическая', '3.0', '29');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('32', 'Volkswagen', 'Polo', '2010', 'Автоматическая', '2.6', '30');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('33', 'Honda', 'CR-V', '2015', 'Автоматическая', '2.7', '17');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('34', 'Ford', 'Kuga', '2010', 'Автоматическая', '1.6', '18');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('35', 'Land Rover', 'Discovery', '2011', 'Автоматическая', '3.0', '21');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('36', 'Volkswagen', 'Golf', '2010', 'Автоматическая', '1.6', '22');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('37', 'Toyota', 'Corolla', '2012', 'Автоматическая', '1.7', '23');
INSERT INTO `Carservice`.`Car` (`IdCar`, `Mark`, `Model`, `Year`, `Transmission`, `Horsepower`, `ClientId`) VALUES ('38', 'Ford', 'Focus', '2010', 'Механическая', '1.6', '31');


INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Диагностика ДВС', '04.03.17', '07.03.17', '1000', '1');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Развал схождение', '05.03.17', '07.03.17', '1500', '2');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`,`Cost`, `CarId`) VALUES ('Ремонт радиатора', '10.03.17', '12.03.17', '1700', '3');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`,`Cost`, `CarId`) VALUES ('Замена катушек зажигания', '11.03.17','14.03.17', '2000', '4');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена датчика вентилятора охлаждения', '14.01.17', '17.01.17', '1700', '5');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Развал схождение', '15.01.17', '17.01.17', '2400', '6');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена замка зажигания', '20.01.17', '27.01.17', '3000', '7');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена лампочки', '05.02.17', '07.02.17', '5500', '8');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Ремонт генератора', '08.02.17', '09.02.17', '5000', '9');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Ремонт стартера', '08.02.17', '10.02.17', '3500', '10');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Компьютерная диагностика ', '10.02.17', '17.02.17', '1400', '11');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена колец', '15.02.17', '17.02.17', '1500', '12');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена крана отопителя', '24.02.17', '27.02.17', '1000', '13');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена одного клапана притирка', '04.03.17', '07.03.17', '1500', '14');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена тосола', '05.03.17', '07.03.17', '1200', '15');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Регулеровка клапанов', '06.03.17', '07.03.17', '1500', '16');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена глушителя', '08.03.17', '09.03.17', '1800', '10');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Развал схождение', '10.03.17', '12.03.17', '3500', '17');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена стартера', '11.03.17', '13.03.17', '4000', '18');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена задней балки', '15.03.17', '17.03.17', '5500', '19');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена резинок стабилизатора', '16.03.17', '17.03.17', '6000', '20');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена рессор', '18.03.17', '19.03.17', '7500', '21');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена ступицы (в сборе)', '20.03.17', '21.03.17', '2500', '22');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена шаровой опоры', '25.03.17', '26.03.17', '3500', '23');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена средней тяги', '25.03.17', '28.03.17', '5000', '9');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена рулевой рейки', '26.03.17', '30.03.17', '2500', '24');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена бампера', '26.03.17', '30.03.17', '1000', '25');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Сварочные работы', '28.03.17', '01.04.17', '1500', '26');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Подкачка колес ', '30.03.17', '30.03.17', '1000', '27');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена вакуумного усилителя (тормозов)', '01.04.17', '03.04.17', '1800', '28');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена заднего крыла', '01.04.17', '05.04.17', '1000', '29');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Рихтовочные работы', '02.04.17', '05.04.17', '1900', '30');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Регулировка замков ', '03.04.17', '05.04.17', '1800', '31');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена резинок стабилизатора', '04.04.17', '10.04.17', '1500', '32');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Установка акустики', '04.04.17', '09.04.17', '1900', '33');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Установка антенны нар./внутрен.', '04.04.17', '10.04.17', '2100', '34');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена обивки двери', '05.04.17', '10.04.17', '2000', '35');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена наружной ручки', '06.04.17', '08.04.17', '2500', '16');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена механического стеклоподъемника', '07.04.17', '09.04.17', '3000', '29');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена руля', '07.04.17', '13.04.17', '3500', '24');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Проверка ходовой части', '08.04.17', '09.04.17', '4000', '25');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена рессор', '09.04.17', '10.04.17', '5200', '26');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена нижнего рычага', '10.04.17', '13.04.17','4000', '17');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена амортизатора', '11.04.17', '15.04.17', '400', '18');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена масла в заднем мосту', '12.04.17', '15.04.17', '700', '19');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена хомута глушителя', '15.04.17', '18.04.17', '1800', '31');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена троса сцепления', '16.04.17', '20.04.17', '4000', '11');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена успокоителя сети', '17.04.17', '19.04.17', '1800', '12');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Замена крана отопителя', '18.04.17', '20.04.17', '3000', '23');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Компьютерная диагностика ', '20.04.17', '22.04.17', '1200', '34');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Диагностика ДВС', '21.04.17', '23.04.17', '1500', '33');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `EndTime`, `Cost`, `CarId`) VALUES ('Развал схождение', '22.04.17', '24.04.17', '1800', '16');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `Cost`, `CarId`) VALUES ('Замена блока предохранителя', '25.04.17', '1900', '37');
INSERT INTO `Carservice`.`Order` (`Title`, `BeginTime`, `Cost`, `CarId`) VALUES ('Замена водяных форсунок`order`', '26.04.17', '5000', '38');
