-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 05, 2022 at 02:33 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `phpmyadmin`
--
CREATE DATABASE IF NOT EXISTS `phpmyadmin` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `phpmyadmin`;

-- --------------------------------------------------------

--
-- Database: `InventoryApp`
--
CREATE DATABASE IF NOT EXISTS `InventoryApp` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `InventoryApp`;

-- --------------------------------------------------------

--
-- Table structure for table `bags`
--

CREATE TABLE `bags` (
  `Type` varchar(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bags`
--

INSERT INTO `bags` (`Type`, `id`) VALUES
('Katta', 1),
('Bardana', 5),
('', 8),
('polythene', 9);

-- --------------------------------------------------------

--
-- Table structure for table `goods`
--

CREATE TABLE `goods` (
  `Name` varchar(256) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `goods`
--

INSERT INTO `goods` (`Name`, `Id`) VALUES
('Toor', 1),
('Soya', 2),
('Chana', 3),
('Turmeric', 6),
('Groundnut', 7),
('Rice', 10);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `Entry_no` int(11) NOT NULL,
  `Billno` int(11) NOT NULL,
  `PartnerName` varchar(100) NOT NULL,
  `MobileNumber` varchar(100) NOT NULL,
  `EmailId` varchar(100) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `DealerSign` varchar(100) NOT NULL,
  `ProcurerSign` varchar(100) NOT NULL,
  `Transportation` varchar(100) NOT NULL,
  `GoodType` varchar(100) NOT NULL,
  `PlantName` varchar(256) NOT NULL,
  `Quantity` varchar(100) NOT NULL,
  `BagType` varchar(100) NOT NULL,
  `NoBags` int(11) NOT NULL,
  `RatePerQuintal` varchar(100) NOT NULL,
  `Subtotal` varchar(100) NOT NULL,
  `TransactionCharges` varchar(100) NOT NULL,
  `QualityDeduction` varchar(100) NOT NULL,
  `FM` int(11) NOT NULL,
  `DM` int(11) NOT NULL,
  `MS` int(11) NOT NULL,
  `TotalAmount` varchar(100) NOT NULL,
  `PaymentMethod` varchar(100) NOT NULL,
  `PaymentStatus` varchar(256) NOT NULL,
  `HandOver` varchar(256) NOT NULL,
  `Remarks` varchar(256) NOT NULL,
  `Amount Pending` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`Entry_no`, `Billno`, `PartnerName`, `MobileNumber`, `EmailId`, `Date`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `PlantName`, `Quantity`, `BagType`, `NoBags`, `RatePerQuintal`, `Subtotal`, `TransactionCharges`, `QualityDeduction`, `FM`, `DM`, `MS`, `TotalAmount`, `PaymentMethod`, `PaymentStatus`, `HandOver`, `Remarks`, `Amount Pending`) VALUES
(7, 0, 'Pravin', '8983000588', 'mohit.marwal@gmail.com', '2022-41-16', 'mohit', 'mohit', 'mh12dk7688', 'Soya', 'Dainika', '56', 'Bardana', 4, '7', '80', '78', '0', 0, 0, 0, '39280780', 'TRF', 'Pending', 'done', 'COmpleted', 0),
(9, 0, 'Pravin', '902106767', 'mohitxp@msn.com', '2022-36-16', 'shilpa', 'shilpa', 'mh14bc7866', 'Toor', 'Dainika', '4', 'Katta', 4, '4', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Complete', 'received', 'Tranaction Done', 0),
(10, 0, 'mohit', '9021306767', 'mohitxp@msn.com', '2022-39-16', 'manan', 'manan', 'gj1bc9856', 'Toor', 'Dainika', '4', 'Katta', 4, '43', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Received', 'Done', 'Transaction complete', 0),
(11, 0, 'mohit', '12345678', 'snika.rathi@gmail.com', '2022-44-16', 'pravin', 'pravin', 'mh12rt5678', 'Toor', 'Dainika', '3', 'Katta', 3, '3', '3', '3', '3', 0, 0, 0, '9333', 'NEFT', 'Received', 'pending', 'pending', 0),
(12, 0, 'Pravin', '823707032252', 'sonika.rathi@msn.com', '09-01-2022', 'pravin', 'pravin', 'mh12dk7688', 'Soya', 'Mantra Organic', '3', 'Bardana', 3, '3', '3', '3', '3', 0, 0, 0, '9333', 'NEFT', 'Received', 'Done', 'Transaction Done', 0),
(13, 0, 'Pravin', '898300588', 'mohit.marwal@gmail.com', '02-01-2022', 'mohit', 'mohit', 'mh12Dk7688', 'Soya', 'Fortune', '4', 'Bardana', 4, '4', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Received', 'Done', 'Transaction Done', 0),
(14, 0, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '13-02-2022', 'mohit', 'mohit', 'mh12dk7688', 'Toor', 'Dainika', '2', 'Katta', 2, '34', '2', '2', '2', 2, 3, 4, '68222', 'NEFT', 'Recived', 'Done', 'transaction completed', 0),
(15, 0, 'sonika', '9876445568', 'sonika.rathi@gmail.com', '13-02-2022', 'sonika', 'sonika', 'Mh12dk7688', 'Turmeric', 'Mantra Organic', '10', 'Bardana', 6, '45', '100', '200', '0', 67, 48, 24, '450100200500', 'NEFT', 'Received', 'Done', 'Transaction Done', 0),
(16, 0, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '05-01-2022', 'mohit', 'mohit', 'mh12dk7688', 'Toor', 'Dainika', '5', 'Katta', 4, '4', '5', '5', '5', 5, 5, 5, '20555', 'NEFT', 'received', 'pending', 'tranasction done', 0),
(17, 0, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '06-01-2022', 'mohit', 'mohit', 'dfssdf', 'Toor', 'Dainika', '4', 'Katta', 3, '2', '3', '5', '4', 3, 3, 3, '8354', 'NEFT', '8000', 'Pending', 'pending', 354),
(18, 12567, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '06-01-2022', 'mohit', 'mohit', 'mh-12rt6789', 'Toor', 'Dainika', '4', 'Katta', 3, '5', '3', '2', '5', 4, 5, 3, '20325', 'NEFT', 'Complete', '20325', 'Complete', 0),
(19, 13576, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '07-01-2022', 'shilpa', 'shilpa', 'mh45-yu8769', 'Toor', 'Dainika', '12504', 'Katta', 4, '100', '1250400', '737.146', '1000', 3, 4, 2, '1248662.854', 'CASH', 'Pending', '1100000', 'complete', 48722),
(20, 13577, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '05-01-2022', 'mohit', 'mohit', '12567', 'Toor', 'Dainika', '4', 'Katta', 3, '3', '3', '4', '2', 2, 3, 0, '12342', 'NEFT', 'Pending', '1234', 'pending', 11108),
(21, 1234567, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '04-03-2022', '234', '234', '234', 'Toor', 'Dainika', '44367', 'Katta', 3, '100', '4436700', '2617.6471', '10', 12, 3, 3, '4434072.3529', 'CASH', 'Pending', '100', '234234234', 4433972),
(22, 12341545, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '04-03-2022', 'qwe', 'qwe', 'qweqweqwe', 'Toor', 'Dainika', '33', 'Katta', 2, '22', '726', '59', '100', 11, 22, 11, '567', 'NEFT', 'Pending', '111', 'adasd', 456);

-- --------------------------------------------------------

--
-- Table structure for table `partner`
--

CREATE TABLE `partner` (
  `Name` varchar(256) NOT NULL,
  `Email` varchar(256) NOT NULL,
  `Id` int(30) NOT NULL,
  `Phone` bigint(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `partner`
--

INSERT INTO `partner` (`Name`, `Email`, `Id`, `Phone`) VALUES
('Pravin', 'pravin.reddy@gmail.com', 1, 9865445689),
('mohit', 'mohit.marwal@gmail.com', 2, 8983000588),
('sonika', 'sonika.rathi@gmail.com', 3, 9876445568),
('ashneer grover', 'ashneer.grover@gmail.com', 4, 7878789045),
('parth', 'parth.marwal@gmail.com', 6, 9876445934);

-- --------------------------------------------------------

--
-- Table structure for table `password`
--

CREATE TABLE `password` (
  `Number` int(11) NOT NULL,
  `Password` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `password`
--

INSERT INTO `password` (`Number`, `Password`) VALUES
(1, 'Pravin');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Method` varchar(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`Method`, `id`) VALUES
('NEFT', 1),
('RTGS', 2),
('TRF', 3),
('CASH', 4);

-- --------------------------------------------------------

--
-- Table structure for table `plant`
--

CREATE TABLE `plant` (
  `Name` varchar(256) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `plant`
--

INSERT INTO `plant` (`Name`, `id`) VALUES
('Dainika', 1),
('Fortune', 2),
('Tata Sampan', 3),
('Mantra Organic', 4),
('HindustanLiver', 5),
('Ashirwad', 6);

-- --------------------------------------------------------

--
-- Table structure for table `quantity`
--

CREATE TABLE `quantity` (
  `Type` varchar(256) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `quantity`
--

INSERT INTO `quantity` (`Type`, `Id`) VALUES
('Quintal', 1),
('Tonnes', 2);

-- --------------------------------------------------------

--
-- Table structure for table `transport`
--

CREATE TABLE `transport` (
  `TruckNo` varchar(11) NOT NULL,
  `DriverName` varchar(11) NOT NULL,
  `PhoneNum` int(11) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bags`
--
ALTER TABLE `bags`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `goods`
--
ALTER TABLE `goods`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`Entry_no`);

--
-- Indexes for table `partner`
--
ALTER TABLE `partner`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `password`
--
ALTER TABLE `password`
  ADD PRIMARY KEY (`Number`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `plant`
--
ALTER TABLE `plant`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `quantity`
--
ALTER TABLE `quantity`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `transport`
--
ALTER TABLE `transport`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bags`
--
ALTER TABLE `bags`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `goods`
--
ALTER TABLE `goods`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `Entry_no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `partner`
--
ALTER TABLE `partner`
  MODIFY `Id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `password`
--
ALTER TABLE `password`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `plant`
--
ALTER TABLE `plant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `quantity`
--
ALTER TABLE `quantity`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `transport`
--
ALTER TABLE `transport`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
