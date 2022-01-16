-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 16, 2022 at 05:02 PM
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
-- Database: `test`
--

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
('Bardana', 5);

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
('Groundnut', 7);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `Entry_no` int(11) NOT NULL,
  `PartnerName` varchar(100) NOT NULL,
  `MobileNumber` varchar(100) NOT NULL,
  `EmailId` varchar(100) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `Time` varchar(100) NOT NULL,
  `DealerSign` varchar(100) NOT NULL,
  `ProcurerSign` varchar(100) NOT NULL,
  `Transportation` varchar(100) NOT NULL,
  `GoodType` varchar(100) NOT NULL,
  `PlantName` varchar(256) NOT NULL,
  `Quantity` varchar(100) NOT NULL,
  `BagType` varchar(100) NOT NULL,
  `NoBags` int(11) NOT NULL,
  `RatePerQuintal` varchar(100) NOT NULL,
  `Comission` varchar(100) NOT NULL,
  `StandardCharges` varchar(100) NOT NULL,
  `OtherCharges` varchar(100) NOT NULL,
  `TotalAmount` varchar(100) NOT NULL,
  `PaymentMethod` varchar(100) NOT NULL,
  `PaymentStatus` varchar(256) NOT NULL,
  `HandOver` varchar(256) NOT NULL,
  `Remarks` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`Entry_no`, `PartnerName`, `MobileNumber`, `EmailId`, `Date`, `Time`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `PlantName`, `Quantity`, `BagType`, `NoBags`, `RatePerQuintal`, `Comission`, `StandardCharges`, `OtherCharges`, `TotalAmount`, `PaymentMethod`, `PaymentStatus`, `HandOver`, `Remarks`) VALUES
(7, 'Pravin', '8983000588', 'mohit.marwal@gmail.com', '2022-41-16', '15:41:19', 'mohit', 'mohit', 'mh12dk7688', 'Soya', 'Dainika', '56', 'Bardana', 4, '7', '80', '78', '0', '39280780', 'TRF', 'Pending', 'done', 'COmpleted'),
(9, 'Pravin', '902106767', 'mohitxp@msn.com', '2022-36-16', '20:36:28', 'shilpa', 'shilpa', 'mh14bc7866', 'Toor', 'Dainika', '4', 'Katta', 4, '4', '4', '4', '4', '16444', 'NEFT', 'Complete', 'received', 'Tranaction Done'),
(10, 'mohit', '9021306767', 'mohitxp@msn.com', '2022-39-16', '20:39:15', 'manan', 'manan', 'gj1bc9856', 'Toor', 'Dainika', '4', 'Katta', 4, '43', '4', '4', '4', '16444', 'NEFT', 'Received', 'Done', 'Transaction complete'),
(11, 'mohit', '12345678', 'snika.rathi@gmail.com', '2022-44-16', '20:44:25', 'pravin', 'pravin', 'mh12rt5678', 'Toor', 'Dainika', '3', 'Katta', 3, '3', '3', '3', '3', '9333', 'NEFT', 'Received', 'pending', 'pending'),
(12, 'Pravin', '823707032252', 'sonika.rathi@msn.com', '2022-20-16', '21:20:55', 'pravin', 'pravin', 'mh12dk7688', 'Soya', 'Mantra Organic', '3', 'Bardana', 3, '3', '3', '3', '3', '9333', 'NEFT', 'Received', 'Done', 'Transaction Done');

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
('Pravin', 'pravin.reddy@gmail.com', 1, 12345678),
('mohit', 'mohit.marwal@gmail.com', 2, 8983000588),
('sonika', 'sonika.rathi@gmail.com', 3, 9876445568);

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
('Mantra Organic', 4);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `goods`
--
ALTER TABLE `goods`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `Entry_no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `partner`
--
ALTER TABLE `partner`
  MODIFY `Id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `plant`
--
ALTER TABLE `plant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
