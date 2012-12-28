CREATE TABLE `customers` (
  `customer_id` int(10) unsigned NOT NULL auto_increment,
  `name` varchar(200) NOT NULL,
  `address` varchar(200) default NULL,
  `postal_code` varchar(10) default NULL,
  `reg_number` int(10) unsigned default NULL,
  PRIMARY KEY  (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1


CREATE TABLE `equipement` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `code` varchar(45) NOT NULL,
  `description` varchar(75) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1

CREATE TABLE `inspection_cert` (
  `inspection_id` int(10) unsigned NOT NULL auto_increment,
  `date` datetime default NULL,
  `customer_id` int(10) unsigned default NULL,
  `comments` longtext,
  `insp_type` varchar(2) default NULL,
  `event_log` tinyint(1) default '0',
  PRIMARY KEY  (`inspection_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12750 DEFAULT CHARSET=latin1

CREATE TABLE `inspection_equipement` (
  `inspec_id` int(10) unsigned NOT NULL,
  `equip_id` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`inspec_id`,`equip_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `instr` (
  `instr_id` int(10) unsigned NOT NULL auto_increment,
  `customer_id` int(10) unsigned default NULL,
  `serial_number` int(10) unsigned default NULL,
  `date` datetime default NULL,
  `approver` varchar(200) default NULL,
  `instr_type_id` int(10) unsigned default NULL,
  `inspection_id` int(11) default '0',
  `meter_index_id` int(4) unsigned default '0',
  `pass` tinyint(1) default NULL,
  PRIMARY KEY  (`instr_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25486 DEFAULT CHARSET=latin1

CREATE TABLE `instr_info` (
  `instr_id` int(10) unsigned NOT NULL,
  `item_number` int(10) unsigned NOT NULL,
  `item_value` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `instr_type` (
  `instr_type_id` int(10) unsigned NOT NULL auto_increment,
  `instr_type` varchar(200) NOT NULL,
  PRIMARY KEY  (`instr_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1

CREATE TABLE `item_units` (
  `item_number` int(10) unsigned default NULL,
  `value` int(10) unsigned NOT NULL,
  `unit_desc` varchar(45) NOT NULL,
  `unit_value` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `items` (
  `instr_type_id` tinyint(4) default NULL,
  `item_num` smallint(6) default NULL,
  `item_desc` varchar(23) default NULL,
  `item_group` tinyint(4) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `meter_index` (
  `meter_index_id` int(10) unsigned NOT NULL default '0',
  `type` varchar(200) NOT NULL,
  `meterdisplacement` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `pressure` (
  `instr_id` int(10) unsigned NOT NULL,
  `p_level` int(10) unsigned NOT NULL,
  `gauge_pressure` double NOT NULL,
  `atm_pressure` double NOT NULL,
  `evc_pressure` double NOT NULL,
  `evc_pfactor` double NOT NULL,
  `evc_unsqr_super` double NOT NULL,
  PRIMARY KEY  USING BTREE (`instr_id`,`p_level`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `temperature` (
  `instr_id` int(10) unsigned NOT NULL,
  `t_level` int(10) unsigned NOT NULL,
  `gauge_temp` double NOT NULL,
  `evc_temp` double NOT NULL,
  `evc_factor` double NOT NULL,
  PRIMARY KEY  USING BTREE (`instr_id`,`t_level`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `volume_test` (
  `instr_id` int(10) unsigned NOT NULL default '0',
  `pulse_input` double NOT NULL,
  `pulser_a` double NOT NULL,
  `pulser_b` double NOT NULL,
  `end_uncor` double NOT NULL,
  `end_cor` double NOT NULL,
  `energy` double default NULL,
  `mech_read` double default NULL,
  PRIMARY KEY  (`instr_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE TABLE `write_items` (
  `customer_id` int(10) unsigned NOT NULL,
  `item_number` int(10) unsigned NOT NULL,
  `instr_type_id` int(10) unsigned NOT NULL,
  `value` varchar(50) default NULL,
  PRIMARY KEY  (`customer_id`,`item_number`,`instr_type_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1

CREATE DEFINER=`admin`@`%` PROCEDURE `inspection`(Out Id INT)
BEGIN

  DECLARE insp_id INT;

  DECLARE insp_count INT;


  SELECT MAX(`inspection_id`) + 1 INTO insp_id FROM `inspection_cert`;

END


CREATE DEFINER=`admin`@`%` PROCEDURE `save_instrument`(In customer_id INT, In serial_number INT, In approver Varchar(100), IN instr_type_id INT, in inspection_id INt,

        Out Instrument_Id INT )
BEGIN

    INSERT INTO instr VALUES (0, customer_id, serial_number, Now(), approver, instr_type_id, inspection_id, 0, NULL);
    select max(instr_id) into Instrument_Id FROM instr;

END

CREATE DEFINER=`admin`@`%` PROCEDURE `save_meter_index`(IN m_index INT,

IN name Varchar(200),

IN m_factor Decimal(10,7),

IN m_unc_turns Int)
BEGIN

  DECLARE instr_index INT DEFAULT -1;

  SELECT `meter_index_id` INTO instr_index FROM `meter_index` WHERE meter_index_id = m_index;

  IF instr_index > -1 THEN

    DELETE FROM `meter_index` WHERE meter_index_id = m_index;

  END IF;

  INSERT INTO `dam_prover`.`meter_index` VALUES (m_index, name, m_factor, m_unc_turns);

END

