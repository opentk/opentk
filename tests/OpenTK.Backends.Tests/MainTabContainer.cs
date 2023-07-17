using ImGuiNET;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace OpenTK.Backends.Tests
{
    public class MainTabContainer : View, IList<View>
    {
        public override string Title => "Main Tab View";

        private readonly List<View> _views;

        public MainTabContainer()
        {
            _views = new List<View>();
        }

        public MainTabContainer(IEnumerable<View> views)
        {
            _views = new List<View>(views);
        }

        private const ImGuiWindowFlags WINDOW_FLAGS =
            ImGuiWindowFlags.NoDecoration |
            ImGuiWindowFlags.NoTitleBar |
            ImGuiWindowFlags.NoResize;
        private const string TAB_VIEW_ID = "main_tab_view_tab_id";

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

            ImGui.BeginTabBar(TAB_VIEW_ID);
            int i = 0;
            foreach (View view in _views)
            {
                if (!view.IsVisible)
                    continue;

                if (ImGui.BeginTabItem($"{view.Title}##{TAB_VIEW_ID}{i++}"))
                {
                    view.Paint();

                    ImGui.EndTabItem();
                }
            }
            ImGui.EndTabItem();

            ImGui.End();
        }


        #region IList<View>
            public View this[int index] { get => ((IList<View>)_views)[index]; set => ((IList<View>)_views)[index] = value; }

            public int Count => ((ICollection<View>)_views).Count;

            public bool IsReadOnly => ((ICollection<View>)_views).IsReadOnly;

            public void Add(View item)
            {
                ((ICollection<View>)_views).Add(item);
            }

            public void Clear()
            {
                ((ICollection<View>)_views).Clear();
            }

            public bool Contains(View item)
            {
                return ((ICollection<View>)_views).Contains(item);
            }

            public void CopyTo(View[] array, int arrayIndex)
            {
                ((ICollection<View>)_views).CopyTo(array, arrayIndex);
            }

            public IEnumerator<View> GetEnumerator()
            {
                return ((IEnumerable<View>)_views).GetEnumerator();
            }

            public int IndexOf(View item)
            {
                return ((IList<View>)_views).IndexOf(item);
            }

            public void Insert(int index, View item)
            {
                ((IList<View>)_views).Insert(index, item);
            }

            public bool Remove(View item)
            {
                return ((ICollection<View>)_views).Remove(item);
            }

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