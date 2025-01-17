﻿-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.
-- INT Id, LONGTEXT(VARCHAR) Name, and INT EmployerId

--Part 2: Write a query to list the names of the employers in St. Louis City.
-- SELECT *
-- FROM Employers
-- WHERE location = "St. Louis";

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.
-- SELECT Skills.SkillName
-- FROM techjobs.Skills
-- INNER JOIN techjobs.JobSkills ON Skills.Id = JobSkills.SkillsId
-- WHERE JobSkills.JobsId = 8
-- ORDER BY Skills.SkillName ASC;