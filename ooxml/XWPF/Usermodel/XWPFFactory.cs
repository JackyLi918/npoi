/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

namespace NPOI.XWPF.UserModel
{
    using System;

    using NPOI.OpenXml4Net.OPC;
    using NPOI.Util;
    using System.Reflection;

    /**
     * @author Yegor Kozlov
     */
    public class XWPFFactory : POIXMLFactory
    {
        private XWPFFactory()
        {

        }

        private static XWPFFactory inst = new XWPFFactory();

        public static XWPFFactory GetInstance()
        {
            return inst;
        }


        /**
         * @since POI 3.14-Beta1
         */
        protected override POIXMLRelation GetDescriptor(String relationshipType)
        {
            return XWPFRelation.GetInstance(relationshipType);
        }

        /**
         * @since POI 3.14-Beta1
         */

        protected override POIXMLDocumentPart CreateDocumentPart(Type cls, Type[] classes, Object[] values)
        {
            if (classes == null)
            {
                classes = [];
            }
            ConstructorInfo constructor = cls.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public,
                    null, classes, null);
            if (constructor == null)
                throw new MissingMethodException();
            if (values == null)
            {
                values = [];
            }
            return constructor.Invoke(values) as POIXMLDocumentPart;
        }

    }
}
