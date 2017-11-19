using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDropExample
{
    public class testHandler : IDropTarget
    {
        void IDropTarget.DragOver(IDropInfo dropInfo)
        {
            // Call default DragOver method, cause most stuff should work by default
            GongSolutions.Wpf.DragDrop.DragDrop.DefaultDropHandler.DragOver(dropInfo);
            //if (dropInfo.TargetGroup == null)
            //{
            //    dropInfo.Effects = System.Windows.DragDropEffects.None;
            //}
        }

        void IDropTarget.Drop(IDropInfo dropInfo)
        {
            // The default drop handler don't know how to set an item's group. You need to explicitly set the group on the dropped item like this.
            GongSolutions.Wpf.DragDrop.DragDrop.DefaultDropHandler.Drop(dropInfo);

            // Now extract the dragged group items and set the new group (target)
            //var data = DefaultDropHandler.ExtractData(dropInfo.Data).OfType<GroupedItem>().ToList();
            //foreach (var groupedItem in data)
            //{
            //    groupedItem.Group = dropInfo.TargetGroup.Name.ToString();
            //}

            // Changing group data at runtime isn't handled well: force a refresh on the collection view.
            //if (dropInfo.TargetCollection is ICollectionView)
            //{
            //    ((ICollectionView)dropInfo.TargetCollection).Refresh();
            //}
        }
    }
}
