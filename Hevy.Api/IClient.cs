using HevyClient.Models;

namespace Hevy.Api
{
    public interface IClient
    {
        Task<Workout[]> GetWorkoutsAsync(int page = 1, int pageSize = 5);
        Task<Workout> PostWorkoutAsync(Workout newWorkout);
        Task<WorkoutCount> GetWorkoutCountAsync();
        Task<Event[]> GetWorkoutEventsAsync(int page = 1, int pageSize = 5, string since = "1970-01-01T00:00:00Z");
        Task<Workout> GetWorkoutAsync(string workoutId);
        Task<Workout> UpdateWorkoutAsync(Workout workout);

        Task<Routine[]> GetRoutinesAsync(int page = 1, int pageSize = 5);
        Task<Routine> PostRoutineAsync(Routine routine);
        Task<Routine> UpdateRoutineAsync(Routine routine);

        Task<ExerciseTemplate[]> GetExerciseTemplatesAsync(int page = 1, int pageSize = 5);
        Task<ExerciseTemplate> GetExerciseTemplateAsync(string exerciseTemplateId);

        Task<RoutineFolder[]> GetRoutineFoldersAsync(int page = 1, int pageSize = 5);
        Task<RoutineFolder> PostRoutineFolderAsync(RoutineFolder routineFolder);
        Task<RoutineFolder> GetRoutineFolderAsync(string routineFolderId);
    }
}
