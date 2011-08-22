using RecommendationSystem.Entities;
using RecommendationSystem.Recommendations;
using RecommendationSystem.Training;

namespace RecommendationSystem.Simple.MostCommonRating
{
    public interface IMostCommonRatingRecommendationSystem : IRecommendationSystem<IMostCommonRatingModel, IUser, ITrainer<IMostCommonRatingModel, IUser>, IRecommender<IMostCommonRatingModel>>
    {}
}