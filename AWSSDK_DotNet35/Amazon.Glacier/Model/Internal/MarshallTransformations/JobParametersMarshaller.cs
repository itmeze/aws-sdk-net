/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobParameters Marshaller
    /// </summary>       
    public class JobParametersMarshaller : IRequestMarshaller<JobParameters, JsonMarshallerContext> 
    {
        public void Marshall(JobParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArchiveId())
            {
                context.Writer.WritePropertyName("ArchiveId");
                context.Writer.Write(requestObject.ArchiveId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetInventoryRetrievalParameters())
            {
                context.Writer.WritePropertyName("InventoryRetrievalParameters");
                context.Writer.WriteObjectStart();

                var marshaller = InventoryRetrievalJobInputMarshaller.Instance;
                marshaller.Marshall(requestObject.InventoryRetrievalParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRetrievalByteRange())
            {
                context.Writer.WritePropertyName("RetrievalByteRange");
                context.Writer.Write(requestObject.RetrievalByteRange);
            }

            if(requestObject.IsSetSNSTopic())
            {
                context.Writer.WritePropertyName("SNSTopic");
                context.Writer.Write(requestObject.SNSTopic);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        public readonly static JobParametersMarshaller Instance = new JobParametersMarshaller();

    }
}