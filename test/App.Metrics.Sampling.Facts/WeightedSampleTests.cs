﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using App.Metrics.ReservoirSampling.ExponentialDecay;
using FluentAssertions;
using Xunit;

namespace App.Metrics.Sampling.Facts
{
    public class WeightedSampleTests
    {
        [Fact]
        public void can_determine_if_weighted_samples_are_diff()
        {
            var first = new WeightedSample(1, null, 1);
            var second = new WeightedSample(1, null, 2);

            first.Should().NotBe(second);
        }

        [Fact]
        public void can_determine_if_weighted_samples_are_diff_using_operator()
        {
            var first = new WeightedSample(1, null, 1);
            var second = new WeightedSample(2, null, 1);

            Assert.True(first != second);
        }

        [Fact]
        public void can_determine_if_weighted_samples_are_same()
        {
            var first = new WeightedSample(1, null, 1);
            var second = new WeightedSample(1, null, 1);

            first.Should().Be(second);
        }

        [Fact]
        public void can_determine_if_weighted_samples_are_same_using_operator()
        {
            var first = new WeightedSample(1, null, 1);
            var second = new WeightedSample(1, null, 1);

            Assert.True(first == second);
        }

        [Fact]
        public void hash_codes_differ_between_instances()
        {
            var first = new WeightedSample(1, null, 1).GetHashCode();
            var second = new WeightedSample(2, null, 1).GetHashCode();

            Assert.NotEqual(first, second);
        }

        [Fact]
        public void hash_codes_same_for_same_instance()
        {
            var first = new WeightedSample(1, null, 1);
            var second = first;

            Assert.Equal(first.GetHashCode(), second.GetHashCode());
        }

        [Fact]
        public void reference_equality_should_be_correct()
        {
            var first = new WeightedSample(1, null, 1);
            var second = new WeightedSample(2, null, 1);

            Assert.False(first.Equals((object)second));
        }
    }
}