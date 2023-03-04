using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Plex.CMS.PlexControlPanel;

namespace Plex.CMS.PlexIntermediate
{
    interface iIntermediate
    {
        /// <summary>
        /// Select All Table fields 
        /// </summary>
        /// <returns>return Query Text</returns>
         DataSet Select();

         /// <summary>
         /// Select Table Fields According to Where Condition
         /// </summary>
         /// <param name="QID">Where Condition</param>
         /// <returns>return Query Text</returns>
         DataSet Select(int id);

         /// <summary>
         /// Delete Row for Table
         /// </summary>
         /// <param name="QID">Row ID to Delete</param>
         /// <returns>return SqlCommand to Execute</returns>
         void Delete(int id);

         /// <summary>
         /// Insert all properties in to table
         /// </summary>
         /// <param name="Qinfo">Class Object Properies</param>
         /// <returns>return SqlCommand to Execute</returns>
         int Insert (object oInfo);

         /// <summary>
         /// Update All Properties Fields on table
         /// </summary>
         /// <param name="Qinfo">Class Object Properies</param>
         /// <returns>return SqlCommand to Execute</returns>
         void update(object oInfo);
    }
}
