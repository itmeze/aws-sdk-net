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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output from the <a>EvaluateExpression</a> action.
    /// </summary>
    public partial class EvaluateExpressionResult : AmazonWebServiceResponse
    {
        private string _evaluatedExpression;

        /// <summary>
        /// Gets and sets the property EvaluatedExpression. 
        /// <para>
        /// The evaluated expression.
        /// </para>
        /// </summary>
        public string EvaluatedExpression
        {
            get { return this._evaluatedExpression; }
            set { this._evaluatedExpression = value; }
        }

        // Check to see if EvaluatedExpression property is set
        internal bool IsSetEvaluatedExpression()
        {
            return this._evaluatedExpression != null;
        }

    }
}