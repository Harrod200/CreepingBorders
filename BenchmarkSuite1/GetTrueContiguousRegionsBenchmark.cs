using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CreepingBorders;
using PavonisInteractive.TerraInvicta;
using System;
using System.Collections.Generic;
using Microsoft.VSDiagnostics;

namespace CreepingBordersBenchmarks
{
    [SimpleJob(warmupCount: 3, targetCount: 5)]
    [CPUUsageDiagnoser]
    public class GetTrueContiguousRegionsBenchmark
    {
        private TINationState _testNation;
        [GlobalSetup]
        public void Setup()
        {
            // Initialize settings if needed
            if (CreepingBordersCls.Settings == null)
            {
                CreepingBordersCls.Settings = new CreepingBordersSettings();
            }

            // Create a mock nation for testing
            // Since we're working with TerraInvicta game objects, we'll need to use actual instances
            // For now, create a minimal test setup
            _testNation = new TINationState();
        }

        [Benchmark]
        public ContiguousRegionsInfo GetTrueContiguousRegionsWithExtended()
        {
            // Call the method being benchmarked
            return TINationStateExtensions.GetTrueContiguousRegionsWithExtended(_testNation);
        }
    }
}