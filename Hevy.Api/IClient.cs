using HevyClient.Models;

namespace Hevy.Api
{
    public interface IClient
    {
        Task<Workout[]> GetWorkoutsAsync(int page = 1, int pageSize = 10);
        Task<Workout> PostWorkoutAsync(Workout newWorkout);
        Task<WorkoutCount> GetWorkoutCountAsync();
        Task<Event[]> GetWorkoutEventsAsync(int page = 1, int pageSize = 10, string since = "1970-01-01T00:00:00Z");
        Task<Workout> GetWorkoutAsync(string workoutId);
        Task<Workout> UpdateWorkoutAsync(Workout workout);
    }
}
