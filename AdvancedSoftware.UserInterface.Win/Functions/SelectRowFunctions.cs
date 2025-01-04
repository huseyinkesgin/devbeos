using AdavancedSoftware.Model.Entities.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSoftware.UserInterface.Win.Functions
{
    public  class SelectRowFunctions
    {
        private GridView _tablo;
        private GridColumn _column;
        private readonly IList<BaseEntity> _selectedRows;
        private RepositoryItemCheckEdit _checkEdit;

        public SelectRowFunctions(GridView tablo, GridColumn column)
        {
            _tablo = tablo;
            _selectedRows = new List<BaseEntity>();

            RemoveEvents();
            AddEvents(tablo);
        }

        public int SelectedRowCount => _selectedRows.Count;
      

       

        public BaseEntity GetSelectedRow(int index)
        {
            return _selectedRows[index];
        }

        public IList<BaseEntity> GetSelectedRows()
        {
            return _selectedRows;
        }

        public int GetSelectedRowIndex(BaseEntity entity)
        {
            return _selectedRows.IndexOf(entity);
        }

        public bool IsRowSelected(int rowHandle)
        {
            var row = _tablo.GetRow<BaseEntity>(rowHandle);
            return GetSelectedRowIndex(row) >= -1;
        }

        public void SelectAll()
        {
            _selectedRows.Clear();
            for (int i = 0; i < _tablo.DataRowCount; i++)
                _selectedRows.Add(_tablo.GetRow<BaseEntity>(i));

            Update();
        }

        private void Update()
        {
            _tablo.BeginUpdate();
            _tablo.EndUpdate();
        }

        public void ClearSelection()
        {
            _selectedRows.Clear();
            Update();
        }

        private void SelectRow(int rowHandle, bool select)
        {
            if (IsRowSelected(rowHandle) == select) return;

            var row = _tablo.GetRow<BaseEntity>(rowHandle);

            if (select)
                _selectedRows.Add(row);
            else
                _selectedRows.Remove(row);

            Update();
        }

        public void RowSelection(int rowHandle)
        {
           if (!_tablo.IsDataRow(rowHandle)) return;
           SelectRow(rowHandle,!IsRowSelected(rowHandle));
        }

        private void AddEvents(GridView tablo)
        {
            if (_tablo == null)
                return;
            _selectedRows.Clear();
            _tablo = tablo;

            _checkEdit = (RepositoryItemCheckEdit)_tablo.GridControl.RepositoryItems.Add("CheckEdit");
            _column = tablo.Columns.Add();
            _column.OptionsColumn.AllowSort = DefaultBoolean.False;
            _column.Visible = true;
            _column.VisibleIndex = 0;
            _column.FieldName = "Secim";
            _column.OptionsColumn.ShowCaption = false;
            _column.OptionsColumn.AllowEdit = false;
            _column.OptionsColumn.AllowSize = false;
            _column.UnboundType = UnboundColumnType.Boolean;
            _column.Width = 35;
            _column.ColumnEdit = _checkEdit;
            _tablo.FocusedColumn = _column;

            if (_tablo is BandedGridView bView)
            {
                bView.Bands["bndSecim"].Visible = true;
                bView.Bands["bndSecim"].VisibleIndex = 0;
                bView.Bands["bndSecim"].Columns.Add((BandedGridColumn)_column);
            }

            _tablo.Click += Tablo_Click;
            _tablo.CustomDrawColumnHeader += Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData += Tablo_CustomUnboundColumnData;
            _tablo.KeyDown += Tablo_KeyDown;
            _tablo.RowStyle += Tablo_RowStyle;
        }

        private void CheckBoxEkle(GraphicsCache cache, Rectangle r, bool check)
        {
            var info = (CheckEditViewInfo)_checkEdit.CreateViewInfo();
            var painter = (CheckEditPainter)_checkEdit.CreatePainter();
            if (info == null) return;
            info.EditValue = check;
            info.Bounds = r;
            info.CalcViewInfo(cache.Graphics);
            var arg = new ControlGraphicsInfoArgs(info, cache, r);
            painter?.Draw(arg);
        }

        private void Tablo_Click(object sender, EventArgs e)
        {
            var point = _tablo.GridControl.PointToClient(Control.MousePosition);

            GridHitInfo info = _tablo.CalcHitInfo(point);

            if (info.Column  == _column)
            {
               if(info.InColumn)
                {
                    if (SelectedRowCount == _tablo.DataRowCount)
                        ClearSelection();
                    else
                        SelectAll();
                }
                else if (info.InRowCell)
                {
                    RowSelection(info.RowHandle);
                }
            }

            else if (info.InRow)
            {
                RowSelection(info.RowHandle);
            }
        }

        private void Tablo_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
           if (e.Column != _column)
                return;
            e.Info.InnerElements.Clear();
            e.Painter.DrawObject(e.Info);
            CheckBoxEkle(e.Cache, e.Bounds,SelectedRowCount == _tablo.DataRowCount);
            e.Handled = true;
        }

        private void Tablo_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            throw new NotImplementedException();
        }

      
        private void RemoveEvents()
        {
            throw new NotImplementedException();
        }
    }
}
