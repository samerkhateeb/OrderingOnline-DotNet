using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace Menu_Module
{
    public class Menu_BLL
    {

        public static string topMenu
        {
            get
            { 
                return String.Format(@"  <a href='{0}{1}' class='Horizontal_Static_Home FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRreEpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Idea FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRreUpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Goals FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrekpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_SignUpWay FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrMEpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_PreRequests FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrMUpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Contact FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrMkpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Prices FloatRight'></a>
                                    ", ConfigurationManager.AppSettings["PortalAlias"], ConfigurationManager.AppSettings["WebsiteHome"]);
            }
        }






    }
}
