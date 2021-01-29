#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
#endregion

namespace WinFormAddin
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        static readonly AddInId addinId = new AddInId(new Guid("80C509DF-2A4F-4B67-A31F-7787BD5964D4"));
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            Element el = doc.GetElement(uidoc.Selection.PickObject(ObjectType.Element));

            double distance = 0;
            bool isHoriz = false;

            using (NewForm thisForm = new NewForm())
            {
                thisForm.ShowDialog();
                if(thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }
                distance = thisForm.getDistance();
                isHoriz = thisForm.isHorizontal();
            }
            XYZ moveVec = null;
            if (isHoriz)
            {
                moveVec = XYZ.BasisX.Multiply(distance);
            }
            else
                moveVec = XYZ.BasisY.Multiply(distance);

            using (Transaction tx = new Transaction(doc))
            {
                tx.Start("Move Object");
                ElementTransformUtils.MoveElement(doc, el.Id, moveVec);

                tx.Commit();
            }

            return Result.Succeeded;
        }
    }
}
