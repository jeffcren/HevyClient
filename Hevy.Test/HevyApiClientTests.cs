using Hevy.Api;
using HevyClient.Models;
using Moq;

namespace Hevy.Test
{
    public class HevyApiClientTests
    {
        [Fact]
        public async Task PostWorkoutAsync_ReturnsCreatedWorkout()
        {
            // Arrange
            var mockClient = new Mock<IClient>();

            var workoutToCreate = new Workout
            {
                Id = "test123",
                Title = "Test Workout",
                StartTime = DateTime.UtcNow.AddHours(-1),
                EndTime = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Description = "Testing",
                Exercises = new List<Exercise>
                {
                    new Exercise
                    {
                        Index = 1,
                        Title = "Test Exercise",
                        Sets = new List<Set>
                        {
                            new Set {
                                Index = 0,
                                Type = "warmup",
                                Reps = 5,
                                WeightKg = 100
                            }
                        }
                    }
                }
            };

            var expectedWorkout = new Workout
            {
                Id = "test123",
                Title = "Test Workout",
                StartTime = workoutToCreate.StartTime,
                EndTime = workoutToCreate.EndTime,
                CreatedAt = workoutToCreate.CreatedAt,
                UpdatedAt = workoutToCreate.UpdatedAt,
                Description = "Testing",
                Exercises = new List<Exercise>
                {
                    new Exercise
                    {
                        Index = 1,
                        Title = "Test Exercise",
                        Sets = new List<Set>
                        {
                            new Set {
                                Index = 0,
                                Type = "warmup",
                                Reps = 5,
                                WeightKg = 100
                            }
                        }
                    }
                }
            };

            mockClient.Setup(c => c.PostWorkoutAsync(workoutToCreate))
                .ReturnsAsync(expectedWorkout);

            // Act
            var result = await mockClient.Object.PostWorkoutAsync(workoutToCreate);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("test123", result.Id);
            Assert.Equal("Test Workout", result.Title);

        }
    }
}
