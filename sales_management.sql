-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 06, 2022 at 08:03 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sales_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin123');

-- --------------------------------------------------------

--
-- Table structure for table `anouncement`
--

CREATE TABLE `anouncement` (
  `id` int(11) NOT NULL,
  `manager_id` int(20) NOT NULL,
  `message` varchar(200) NOT NULL,
  `date` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `anouncement`
--

INSERT INTO `anouncement` (`id`, `manager_id`, `message`, `date`) VALUES
(1, 1, 'Hello from manager', '2022-01-04 23:48:18.000000'),
(3, 6, 'Another announcement!!!', '2022-01-05 00:42:53.000000'),
(5, 0, 'Shampoo is available', '2022-01-07 22:59:11.000000'),
(6, 0, 'there is a new product available now', '2022-01-08 20:44:05.000000'),
(7, 0, 'you should try your best to relation between you and the consumer', '2022-01-08 20:58:27.000000'),
(8, 0, 'new annoucement for everybody', '2022-01-08 21:17:46.000000'),
(10, 0, 'the seminar will be held tomorrow', '2022-01-08 22:51:38.000000'),
(11, 0, 'the seminar will be held tomorrow', '2022-01-08 22:51:38.000000'),
(12, 0, 'Hello How are you', '2022-01-08 23:36:16.000000');

-- --------------------------------------------------------

--
-- Table structure for table `manager`
--

CREATE TABLE `manager` (
  `id` int(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `manager`
--

INSERT INTO `manager` (`id`, `username`, `password`) VALUES
(9, 'arif', '1234'),
(10, 'akash', '1234'),
(11, 'rifat', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `opportunities_manaagement`
--

CREATE TABLE `opportunities_manaagement` (
  `id` int(20) NOT NULL,
  `name` varchar(20) NOT NULL,
  `date_time` varchar(10) NOT NULL,
  `type` varchar(20) NOT NULL,
  `chance_to_close` varchar(200) NOT NULL,
  `budget` varchar(200) NOT NULL,
  `duration` varchar(200) NOT NULL,
  `contact_name` varchar(200) NOT NULL,
  `contact_number` varchar(200) NOT NULL,
  `description` varchar(200) NOT NULL,
  `notes` varchar(200) NOT NULL,
  `user_id` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `opportunities_manaagement`
--

INSERT INTO `opportunities_manaagement` (`id`, `name`, `date_time`, `type`, `chance_to_close`, `budget`, `duration`, `contact_name`, `contact_number`, `description`, `notes`, `user_id`) VALUES
(1, 'Soap', '2022-01-07', 'Comsmetic', '10', '10000', '10', 'Rifat', '0189', 'Cosmetic product', 'no notes', '4'),
(2, 'olive oil', '2022-01-08', '4', '10', '1000', '5', 'rifat', '093', 'olive oil is now a closest price', 'godd for skin', '4'),
(3, 'vesline', '2022-01-08', 'liquide', '10', '2000', '7', 'rifat', '019', 'the product is good for skin in winter sesson', 'the product is available', '6'),
(4, 'sampoo', '2022-01-08', 'liquid', '10', '1000', '7', 'akash', '0019', 'special  winnter session sampoo', 'best product for hair in winter session', '6'),
(8, 'Toothpaste', '2022-01-08', 'accessories', '10', '10000', '10', 'Akash', '91231', 'For dental ', 'djhasd', '6'),
(9, 'Sunsilk', '2022-03-15', 'Accessories', '10', '5000', '7', 'Arif', '01289891421', 'Shampoo', 'Good', '5'),
(10, 'soap', '2022-03-16', 'good', '10', '1000', '15', 'sumon', '08856', 'this product has no side effect', 'offer limited', '5');

-- --------------------------------------------------------

--
-- Table structure for table `project`
--

CREATE TABLE `project` (
  `id` int(20) NOT NULL,
  `user_id` varchar(20) NOT NULL,
  `name` varchar(200) NOT NULL,
  `amount` varchar(200) NOT NULL,
  `revanue` varchar(200) NOT NULL,
  `description` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `launchdate` varchar(20) NOT NULL,
  `duration` varchar(200) NOT NULL,
  `contactname` varchar(200) NOT NULL,
  `contact mobile` varchar(200) NOT NULL,
  `notes` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `project`
--

INSERT INTO `project` (`id`, `user_id`, `name`, `amount`, `revanue`, `description`, `status`, `launchdate`, `duration`, `contactname`, `contact mobile`, `notes`) VALUES
(3, '6', 'Pen', '100', '200', 'Writting accessories', 'active', '2022-01-08 23:42:26', '10', 'Akash', '019', 'Matador pen');

-- --------------------------------------------------------

--
-- Table structure for table `proposal_management`
--

CREATE TABLE `proposal_management` (
  `product_id` int(20) NOT NULL,
  `user_id` int(20) NOT NULL,
  `product_name` varchar(200) NOT NULL,
  `budget` varchar(20) NOT NULL,
  `amount` varchar(20) NOT NULL,
  `duration` varchar(20) NOT NULL,
  `contact_name` varchar(200) NOT NULL,
  `contact_number` varchar(20) NOT NULL,
  `description` varchar(200) NOT NULL,
  `rejected_reason` varchar(200) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `proposal_management`
--

INSERT INTO `proposal_management` (`product_id`, `user_id`, `product_name`, `budget`, `amount`, `duration`, `contact_name`, `contact_number`, `description`, `rejected_reason`, `status`) VALUES
(1, 2, 'Shampoo', '2000', '20', '10', 'Akash', '019', 'This soap is good for skin', 'Some side effectes', 'active'),
(2, 4, 'olive oil', '10000', '2000', '10', 'rifat', '019', 'available only for winter session', 'some side effects', 'active'),
(3, 6, 'meril', '1000', '2000', '1', 'sumon', '019', 'this is a cold product', 'rejected when the summer will come', 'active'),
(4, 6, 'vesline', '1000', '20', '10', 'arif', '019', 'this product use only in every night', 'when you may need a very good product', 'active'),
(5, 7, 'saop', '1000', '200', '10', 'sumon', '0019', 'good', 'any side effect', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `id` int(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`id`, `username`, `password`) VALUES
(1, 'karim', '1234'),
(4, 'rifat', '1234'),
(5, 'arif', '1234'),
(6, 'akash', '1234'),
(7, 'sumon', '1234'),
(9, 'sagar', '1234'),
(10, 'siam', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `anouncement`
--
ALTER TABLE `anouncement`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manager`
--
ALTER TABLE `manager`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `opportunities_manaagement`
--
ALTER TABLE `opportunities_manaagement`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `project`
--
ALTER TABLE `project`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `proposal_management`
--
ALTER TABLE `proposal_management`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `anouncement`
--
ALTER TABLE `anouncement`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `manager`
--
ALTER TABLE `manager`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `opportunities_manaagement`
--
ALTER TABLE `opportunities_manaagement`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `project`
--
ALTER TABLE `project`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `proposal_management`
--
ALTER TABLE `proposal_management`
  MODIFY `product_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
