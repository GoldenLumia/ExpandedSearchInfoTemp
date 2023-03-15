using System;
using ExpandedSearchInfoTemp.Providers;

namespace ExpandedSearchInfoTemp.Sections {
    public interface ISearchInfoSection {
        IProvider Provider { get; }
        string Name { get; }
        Uri Uri { get; }

        void Draw();
    }
}
