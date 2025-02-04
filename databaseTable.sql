  CREATE TABLE "XKRAJCOVICM2"."LEKAR" 
   (	"ID" NUMBER(*,0) NOT NULL ENABLE, 
	"EMAIL" VARCHAR2(50 BYTE), 
	"MENO" VARCHAR2(15 BYTE), 
	"PRIEZVISKO" VARCHAR2(25 BYTE), 
	"TELEFON" NUMBER(*,0), 
	"DATUM_NASTUPU" DATE, 
	"SPECIALIZACIA" VARCHAR2(20 BYTE), 
	"DOCHADZKA" VARCHAR2(20 BYTE), 
	 CONSTRAINT "LEKÁR_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "DTBZ_2023"  ENABLE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "DTBZ_2023" ;
