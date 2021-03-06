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

namespace System.Windows.Controls
{
  public class RowDefinition : DefinitionBase
  {
    #region Constructors

    static RowDefinition()
    {
      MaxHeightProperty = DependencyProperty.Register("MaxHeight", typeof (double), typeof (RowDefinition));
      MinHeightProperty = DependencyProperty.Register("MinHeight", typeof (double), typeof (RowDefinition));
      HeightProperty = DependencyProperty.Register("Height", typeof (GridLength), typeof (RowDefinition),
                                                   new PropertyMetadata(new GridLength(GridUnitType.Star)));
    }

    public RowDefinition() {}

    #endregion Constructors

    #region Properties

    public double ActualHeight
    {
      get { return ((GridLength)GetValue(HeightProperty)).Value; }
    }

    public GridLength Height
    {
      get { return (GridLength)GetValue(HeightProperty); }
      set { SetValue(HeightProperty, value); }
    }

    public double MaxHeight
    {
      get { return (double)GetValue(MaxHeightProperty); }
      set { SetValue(MaxHeightProperty, value); }
    }

    public double MinHeight
    {
      get { return (double)GetValue(MinHeightProperty); }
      set { SetValue(MinHeightProperty, value); }
    }

    public double Offset
    {
      get { return _offset; }
    }

    #endregion Properties

    #region Properties (Dependency)

    public static readonly DependencyProperty HeightProperty;
    public static readonly DependencyProperty MaxHeightProperty;
    public static readonly DependencyProperty MinHeightProperty;

    #endregion Properties (Dependency)

    #region Fields

    private double _offset = 0;

    #endregion Fields
  }
}