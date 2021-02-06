USE [adm_wlc]
GO
/****** Object:  Table [dbo].[conv_result]    Script Date: 04/02/2021 16.23.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conv_result](
	[b1] [varchar](50) NULL,
	[b2] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[process_status]    Script Date: 04/02/2021 16.23.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[process_status](
	[cc_link_no] [int] NULL,
	[process_name] [varchar](50) NULL,
	[pid] [varchar](50) NULL,
	[model_code] [varchar](50) NULL,
	[job_code_b1] [varchar](50) NULL,
	[job_code_b2] [varchar](50) NULL,
	[standard_progress] [varchar](50) NULL,
	[current_progress] [varchar](50) NULL,
	[margin_of_delay] [varchar](50) NULL,
	[margin_of_adv] [varchar](50) NULL,
	[cut_off] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[process_table]    Script Date: 04/02/2021 16.23.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[process_table](
	[cc_link_no] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sa_name] [varchar](50) NULL,
	[process_name] [varchar](50) NULL,
	[process_type] [varchar](50) NULL,
	[normal_reverse] [varchar](50) NULL,
	[margin_reverse] [varchar](50) NULL,
	[depth] [varchar](50) NULL,
	[margin_of_adv] [varchar](50) NULL,
	[margin_of_delay] [varchar](50) NULL,
	[cut_off] [varchar](50) NULL,
	[memo] [varchar](50) NULL,
	[end] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prod_inst]    Script Date: 04/02/2021 16.23.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prod_inst](
	[cc_link_no] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[del] [varchar](50) NULL,
	[wlc_code] [varchar](50) NULL,
	[katashiki] [varchar](50) NULL,
	[model_code] [varchar](50) NULL,
	[1_b1] [varchar](50) NULL,
	[1_b2] [varchar](50) NULL,
	[2_b1] [varchar](50) NULL,
	[2_b2] [varchar](50) NULL,
	[3_b1] [varchar](50) NULL,
	[3_b2] [varchar](50) NULL,
	[4_b1] [varchar](50) NULL,
	[4_b2] [varchar](50) NULL,
	[5_b1] [varchar](50) NULL,
	[5_b2] [varchar](50) NULL,
	[6_b1] [varchar](50) NULL,
	[6_b2] [varchar](50) NULL,
	[7_b1] [varchar](50) NULL,
	[7_b2] [varchar](50) NULL,
	[8_b1] [varchar](50) NULL,
	[8_b2] [varchar](50) NULL,
	[9_b1] [varchar](50) NULL,
	[9_b2] [varchar](50) NULL,
	[10_b1] [varchar](50) NULL,
	[10_b2] [varchar](50) NULL,
	[11_b1] [varchar](50) NULL,
	[11_b2] [varchar](50) NULL,
	[12_b1] [varchar](50) NULL,
	[12_b2] [varchar](50) NULL,
	[13_b1] [varchar](50) NULL,
	[13_b2] [varchar](50) NULL,
	[14_b1] [varchar](50) NULL,
	[14_b2] [varchar](50) NULL,
	[15_b1] [varchar](50) NULL,
	[15_b2] [varchar](50) NULL,
	[16_b1] [varchar](50) NULL,
	[16_b2] [varchar](50) NULL,
	[17_b1] [varchar](50) NULL,
	[17_b2] [varchar](50) NULL,
	[18_b1] [varchar](50) NULL,
	[18_b2] [varchar](50) NULL,
	[19_b1] [varchar](50) NULL,
	[19_b2] [varchar](50) NULL,
	[20_b1] [varchar](50) NULL,
	[20_b2] [varchar](50) NULL,
	[21_b1] [varchar](50) NULL,
	[21_b2] [varchar](50) NULL,
	[22_b1] [varchar](50) NULL,
	[22_b2] [varchar](50) NULL,
	[23_b1] [varchar](50) NULL,
	[23_b2] [varchar](50) NULL,
	[24_b1] [varchar](50) NULL,
	[24_b2] [varchar](50) NULL,
	[25_b1] [varchar](50) NULL,
	[25_b2] [varchar](50) NULL,
	[26_b1] [varchar](50) NULL,
	[26_b2] [varchar](50) NULL,
	[27_b1] [varchar](50) NULL,
	[27_b2] [varchar](50) NULL,
	[28_b1] [varchar](50) NULL,
	[28_b2] [varchar](50) NULL,
	[29_b1] [varchar](50) NULL,
	[29_b2] [varchar](50) NULL,
	[30_b1] [varchar](50) NULL,
	[30_b2] [varchar](50) NULL,
	[end] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stamping_result]    Script Date: 04/02/2021 16.23.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stamping_result](
	[date] [varchar](50) NULL,
	[time] [time](7) NULL,
	[pid] [varchar](50) NULL,
	[chassis_number] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wlc_data]    Script Date: 04/02/2021 16.23.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wlc_data](
	[seq] [int] NOT NULL,
	[pid] [varchar](50) NULL,
	[vin] [varchar](50) NULL,
	[plan_date] [date] NULL,
	[wlc_code] [varchar](50) NULL,
	[model_code] [varchar](50) NULL,
	[suffix] [varchar](50) NULL,
	[chassis_number] [varchar](50) NULL,
	[classification] [varchar](50) NULL
) ON [PRIMARY]
GO
