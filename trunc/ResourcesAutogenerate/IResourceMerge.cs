﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Common.Excel;
using Common.Excel.Contracts;
using Common.Excel.Models;
using EnvDTE;

namespace ResourcesAutogenerate
{
    public interface IResourceMerge
    {
        void SetLogger(ILogger logger);

        Task UpdateResourcesAsync(IReadOnlyCollection<int> selectedCultures, IReadOnlyCollection<Project> selectedProjects, IStatusProgress progress, CancellationToken cancellationToken, bool removeFiles = true);

        Task ExportToDocumentAsync(IDocumentGenerator documentGenerator, string path, IReadOnlyCollection<int> selectedCultures, IReadOnlyCollection<Project> selectedProjects, IStatusProgress progress, CancellationToken cancellationToken);
        Task ImportFromDocumentAsync(IDocumentGenerator document, string path, IReadOnlyCollection<int> selectedCultures, IReadOnlyCollection<Project> selectedProjects, IStatusProgress progress, CancellationToken cancellationToken);
    }
}
