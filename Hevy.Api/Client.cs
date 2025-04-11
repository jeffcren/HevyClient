using HevyClient.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Hevy.Api
{
    public class Client : IClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.hevyapp.com/";

        public Client(string apiKey)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(BaseUrl) };
            _httpClient.DefaultRequestHeaders.Add("api-key", apiKey);
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, TRequest payload)
        {
            var json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(jsonResponse);
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string endpoint, TRequest payload)
        {
            var json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(jsonResponse);
        }

        public async Task<Workout[]> GetWorkoutsAsync(int page = 1, int pageSize = 10)
        {
            string endpoint = $"workouts?page={page}&pageSize={pageSize}";
            return await GetAsync<Workout[]>(endpoint);
        }

        public async Task<Workout> PostWorkoutAsync(Workout newWorkout)
        {
            return await PostAsync<Workout, Workout>("workouts", newWorkout);
        }

        public async Task<WorkoutCount> GetWorkoutCountAsync()
        {
            string endpoint = "workouts/count";
            return await GetAsync<WorkoutCount>(endpoint);
        }

        public async Task<Event[]> GetWorkoutEventsAsync(int page = 1, int pageSize = 10, string since = "1970-01-01T00:00:00Z")
        {
            string endpoint = $"workouts/events?page={page}&pageSize={pageSize}";
            return await GetAsync<Event[]>(endpoint);
        }

        public async Task<Workout> GetWorkoutAsync(string workoutId)
        {
            string endpoint = $"workouts/{workoutId}";
            return await GetAsync<Workout>(endpoint);
        }

        public async Task<Workout> UpdateWorkoutAsync(Workout workout)
        {
            string endpoint = $"workouts/{workout.Id}";
            return await PutAsync<Workout, Workout> (endpoint, workout);
        }
    }
}
