USE [test_block];
-- Connection 2
-- Stop, then set the LOCK_TIMEOUT, then retry
SET LOCK_TIMEOUT -1;
SELECT [ID], [Price]
FROM dbo.[t1]
WHERE [ID] = 2;