﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecommendationSystem.Knn.Similarity;

namespace RecommendationSystem.Knn.Recommendations
{
    public interface IRatingAggregator
    {
        double Aggregate(User user, string artist);
    }
}