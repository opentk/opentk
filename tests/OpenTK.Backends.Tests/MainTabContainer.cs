using ImGuiNET;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// The main container that houses all tabs.
    /// </summary>
    public class MainTabContainer : IEnumerable<View>
    {
        private readonly List<View> _views;
        private int activeItem = -1;

        /// <summary>
        /// Create a new instance of MainTabContainer.
        /// </summary>
        public MainTabContainer()
        {
            _views = new List<View>();
        }

        /// <summary>
        /// Create a new instance of MainTabContainer.
        /// </summary>
        public MainTabContainer(IEnumerable<View> views)
        {
            _views = new List<View>(views);
        }

        private const ImGuiWindowFlags WINDOW_FLAGS =
            ImGuiWindowFlags.NoDecoration |
            ImGuiWindowFlags.NoTitleBar |
            ImGuiWindowFlags.NoResize;
        private const string TAB_VIEW_ID = "main_tab_view_tab_id";

        /// <inheritdoc/>
        public void Initialize()
        {
            foreach (View view in _views)
            {
                // FIXME: Some other property to tell us that the view shouldn't/can't be initialized
                if (view.IsVisible)
                    view.Initialize();
            }
        }

        /// <inheritdoc/>
        public void Paint(double deltaTime)
        {
            Vector2 size = ImGui.GetIO().DisplaySize;

            ImGui.SetNextWindowPos(Vector2.Zero);
            ImGui.SetNextWindowSize(size);

            if (ImGui.Begin("###main", WINDOW_FLAGS) == false)
                return;

            if (_views.Count(x => x.IsVisible) == 0) /* evil linq to prevent a crash. */
            {
                ImGui.End();
                return;
            }

            if (ImGui.BeginTabBar(TAB_VIEW_ID, ImGuiTabBarFlags.FittingPolicyResizeDown))
            {
                for (int i = 0; i < _views.Count; i++)
                {
                    View view = _views[i];

                    if (!view.IsVisible)
                        continue;

                    if (ImGui.BeginTabItem($"{view.Title}##{TAB_VIEW_ID}{i}"))
                    {
                        if (i != activeItem)
                        {
                            if (activeItem != -1)
                                _views[activeItem].NotifyLeave();
                            view.NotifyEnter();

                            activeItem = i;
                        }

                        ImGui.BeginChild($"##{i}");
                        view.Paint(deltaTime);
                        ImGui.EndChild();

                        ImGui.EndTabItem();
                    }
                }
                ImGui.EndTabBar();
            }

            ImGui.End();
        }

        public View? this[Type type]
        {
            get
            {
                foreach (View view in _views)
                {
                    if (view.GetType() == type)
                        return view;
                }
                return null;
            }
        }

        #region IEnumerable<View>
        /// <inheritdoc/>
        public int Count => _views.Count;

        /// <inheritdoc/>
        public void Add(View item)
        {
            _views.Add(item);
        }

        /// <inheritdoc/>
        public IEnumerator<View> GetEnumerator()
        {
            return _views.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_views).GetEnumerator();
        }
        #endregion
    }
}
