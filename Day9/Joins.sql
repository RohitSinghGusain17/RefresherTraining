-- 1) Display the course and the section information.
SELECT C.*, S.*
FROM COURSE C
INNER JOIN SECTION S
ON C.COURSE_NO = S.COURSE_NO;

-- 2) Display the instructor details along with the city and the state that they live in.
SELECT I.*, Z.CITY, Z.STATE
FROM INSTRUCTOR I
INNER JOIN ZIPCODE Z
ON I.ZIP = Z.ZIP;

-- 1) Display the course number, description and pre-requisite along with section id. 
-- Those courses who do not have sections defined should also be displayed.
SELECT C.COURSE_NO, C.DESCRIPTION, C.PREREQUISITE, S.SECTION_ID
FROM COURSE C
LEFT JOIN SECTION S
ON C.COURSE_NO = S.COURSE_NO;

-- 2) For the above query also include courses where no instructor is assigned.
SELECT C.COURSE_NO, C.DESCRIPTION, C.PREREQUISITE, S.SECTION_ID, I.INSTRUCTOR_ID, I.FIRST_NAME, I.LAST_NAME
FROM COURSE C
LEFT JOIN SECTION S
ON C.COURSE_NO = S.COURSE_NO
LEFT JOIN INSTRUCTOR I
ON S.INSTRUCTOR_ID = I.INSTRUCTOR_ID;