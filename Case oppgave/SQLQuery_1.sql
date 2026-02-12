DECLARE @Returns TABLE (DayNo int, DailyReturn float);

INSERT INTO @Returns (DayNo, DailyReturn) VALUES
(1,  0.0),
(2,  0.0),
(3, -0.006253657),
(4, -0.00361612),
(5, -0.004777986),
(6, -0.026842209),
(7,  0.000095331),
(8,  0.0),
(9,  0.0),
(10,-0.004793408);

SELECT 
    EXP(SUM(LOG(1.0 + DailyReturn))) - 1.0 AS TWR
FROM @Returns;
