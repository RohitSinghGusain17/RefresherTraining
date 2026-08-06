-- 1) Display the course number and description whose cost is same as that of the course whose prerequisite is 20.
SELECT COURSE_NO, DESCRIPTION
FROM COURSE
WHERE COST = (
    SELECT COST 
    FROM COURSE
    WHERE PREREQUISITE = 20
);

-- 2) Modify the above query to display the records whose cost is not same as that of the course whose prerequisite is 20.
SELECT COURSE_NO, DESCRIPTION
FROM COURSE
WHERE COST <> (
    SELECT COST
    FROM COURSE
    WHERE PREREQUISITE = 20
);

-- 3) Display the course description and cost of the courses where the capacity is less than or equal to the average capacity and cost is equal to minimum cost.
SELECT DISTINCT C.DESCRIPTION, C.COST
FROM COURSE C
INNER JOIN SECTION S
ON C.COURSE_NO = S.COURSE_NO
WHERE S.CAPACITY <= (
    SELECT AVG(CAST(CAPACITY AS DECIMAL(10,2)))
    FROM SECTION
)
AND C.COST = (
    SELECT MIN(COST)
    FROM COURSE
);