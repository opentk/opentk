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
    public class MainTabContainer : View, IList<View>
    {
        /// <inheritdoc/>
        public override string Title => "Main Tab View";

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
        public override void Initialize()
        {
            foreach (View view in _views)
            {
                view.Initialize();
            }
        }

        /// <inheritdoc/>
        public override void Paint()
        {
            Vector2 size = ImGui.GetIO().DisplaySize;

            ImGui.SetNextWindowPos(Vector2.Zero);
            ImGui.SetNextWindowSize(size);

            if (ImGui.Begin(string.Empty, WINDOW_FLAGS) == false)
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
                        view.Paint();
                        ImGui.EndChild();

                        ImGui.EndTabItem();
                    }
                }
                ImGui.EndTabBar();
            }
            
            ImGui.End();
        }


        #region IList<View>
            /// <inheritdoc/>
            public View this[int index] { get => ((IList<View>)_views)[index]; set => ((IList<View>)_views)[index] = value; }

            /// <inheritdoc/>
            public int Count => ((ICollection<View>)_views).Count;

            /// <inheritdoc/>
            public bool IsReadOnly => ((ICollection<View>)_views).IsReadOnly;

            /// <inheritdoc/>
            public void Add(View item)
            {
                ((ICollection<View>)_views).Add(item);
            }

            /// <inheritdoc/>
            public void Clear()
            {
                ((ICollection<View>)_views).Clear();
            }

            /// <inheritdoc/>
            public bool Contains(View item)
            {
                return ((ICollection<View>)_views).Contains(item);
            }

            /// <inheritdoc/>
            public void CopyTo(View[] array, int arrayIndex)
            {
                ((ICollection<View>)_views).CopyTo(array, arrayIndex);
            }

            /// <inheritdoc/>
            public IEnumerator<View> GetEnumerator()
            {
                return ((IEnumerable<View>)_views).GetEnumerator();
            }

            /// <inheritdoc/>
            public int IndexOf(View item)
            {
                return ((IList<View>)_views).IndexOf(item);
            }

            /// <inheritdoc/>
            public void Insert(int index, View item)
            {
                ((IList<View>)_views).Insert(index, item);
            }

            /// <inheritdoc/>
            public bool Remove(View item)
            {
                return ((ICollection<View>)_views).Remove(item);
            }

            /// <inheritdoc/>
            public void RemoveAt(int index)
            {
                ((IList<View>)_views).RemoveAt(index);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)_views).GetEnumerator();
            }
        #endregion
    }
}
