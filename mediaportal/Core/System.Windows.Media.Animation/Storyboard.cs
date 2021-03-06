#region Copyright (C) 2005-2011 Team MediaPortal

// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

namespace System.Windows.Media.Animation
{
  public class Storyboard : ParallelTimeline
  {
    #region Constructors

    static Storyboard()
    {
      TargetNameProperty = DependencyProperty.Register("TargetName", typeof (string), typeof (Storyboard));
      TargetPropertyProperty = DependencyProperty.Register("TargetProperty", typeof (DependencyProperty),
                                                           typeof (Storyboard));
    }

    public Storyboard() {}

    #endregion Constructors

    #region Methods

    public static string GetTargetName(DependencyObject d)
    {
      return (string)d.GetValue(TargetNameProperty);
    }

    public static string GetTargetProperty(DependencyObject d)
    {
      return (string)d.GetValue(TargetPropertyProperty);
    }

    public static void SetTargetName(DependencyObject d, string name)
    {
      d.SetValue(TargetNameProperty, name);
    }

    public static void SetTargetProperty(DependencyObject d, DependencyProperty property)
    {
      d.SetValue(TargetPropertyProperty, property);
    }

    #endregion Methods

    #region Properties

    public string TargetName
    {
      get { return (string)GetValue(TargetNameProperty); }
      set { SetValue(TargetNameProperty, value); }
    }

    public string TargetProperty
    {
      get { return (string)GetValue(TargetPropertyProperty); }
      set { SetValue(TargetPropertyProperty, value); }
    }

    #endregion Properties

    #region Properties (Dependency)

    public static readonly DependencyProperty TargetNameProperty;
    public static readonly DependencyProperty TargetPropertyProperty;

    #endregion Properties (Dependency)
  }
}