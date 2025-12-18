# PatternPractice .NET 10.0 Upgrade Tasks

## Overview

This document tracks the execution of the PatternPractice solution upgrade from .NET 9.0 to .NET 10.0. The single project will be upgraded in one atomic operation, followed by validation.

**Progress**: 0/2 tasks complete (0%) ![0%](https://progress-bar.xyz/0)

---

## Tasks

### [▶] TASK-001: Atomic framework upgrade and package cleanup
**References**: Plan §Phase 1, Plan §Package Update Reference, Plan §Breaking Changes Catalog

- [ ] (1) Update TargetFramework to net10.0 in PatternPractice\PatternPractice.csproj
- [ ] (2) TargetFramework property updated to net10.0 (**Verify**)
- [ ] (3) Remove System.Data.DataSetExtensions package reference from PatternPractice\PatternPractice.csproj
- [ ] (4) System.Data.DataSetExtensions package reference removed (**Verify**)
- [ ] (5) Restore NuGet packages
- [ ] (6) All packages restored successfully (**Verify**)
- [ ] (7) Build solution and fix all compilation errors per Plan §Breaking Changes Catalog
- [ ] (8) Solution builds with 0 errors (**Verify**)
- [ ] (9) Commit changes with message: "TASK-001: Upgrade to .NET 10.0 (net9.0 → net10.0)"

---

### [ ] TASK-002: Validate upgrade and functionality
**References**: Plan §Phase 2 Validation, Plan §Testing & Validation Strategy

- [ ] (1) Run PatternPractice application
- [ ] (2) Application starts without exceptions (**Verify**)
- [ ] (3) Verify configuration values load correctly (ConfigManager.MethodFactoryKey, AbstractFactoryKey, BuilderKey, AdapterKey)
- [ ] (4) All configuration values accessible and not null (**Verify**)
- [ ] (5) Test core design pattern implementations
- [ ] (6) Application functions correctly without runtime exceptions (**Verify**)
- [ ] (7) Commit validation results with message: "TASK-002: Complete .NET 10.0 upgrade validation"

---
