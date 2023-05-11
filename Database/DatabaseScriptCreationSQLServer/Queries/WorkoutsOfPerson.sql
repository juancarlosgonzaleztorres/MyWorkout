--SELECT *
--FROM Excercises

--SELECT *
--FROM Workouts

--select * from persons

--GET all sets of workouts of Juan
SELECT p.FirstName, p.lastName, e.Name, s.weight
FROM dbo.persons p
INNER JOIN Link_Workout_Person lwp ON lwp.personId = p.Id
INNER JOIN [dbo].[Workouts] w ON w.Id = lwp.WorkoutId
inner join [dbo].[Link_Workout_Set] lws on w.id = lws.workoutId
inner join [dbo].[Sets] s on s.id = lws.setId
inner join dbo.Excercises e on e.Id = s.ExcerciseID
WHERE p.firstName like 'Juan'