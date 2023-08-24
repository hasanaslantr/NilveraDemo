 <xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" omit-xml-declaration="yes"/>
    
    <style>
        .container {
            display: flex;
            flex-direction: row;
            margin: 5px;
            padding: 5px;
            border: 1px solid #ccc;
            background-color: #f5f5f5;
        }
        .field {
            flex: 1;
            margin: 3px;
            padding: 3px;
        }
        .field-name {
            font-weight: bold;
        }
    </style>

    <xsl:template match="/ArrayOfInvoice">
        <html>
            <head>
                <title>Invoices</title>
            </head>
            <body>
                <!-- Her Invoice öğesi için döngü -->
                <xsl:for-each select="Invoice">
                    <div class="container">
                        <!-- Her alanı işle -->
                        <xsl:apply-templates select="UUID | TaxNumber | InvoiceNumber | InvoiceProfile | InvoiceType | IssueDate | CreatedDate | CurrencyCode | PayableAmount | Alias | ReceiverName | ReceiverTaxNumber | IsPrint"/>
                    </div>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
    
    <!-- Alanları eşleştir ve renklendir -->
    <xsl:template match="UUID | TaxNumber | InvoiceNumber | InvoiceProfile | InvoiceType | IssueDate | CreatedDate | CurrencyCode | PayableAmount | Alias | ReceiverName | ReceiverTaxNumber | IsPrint">
        <div class="field">
            <span class="field-name">
                <xsl:value-of select="local-name()"/>:
            </span>
            <xsl:value-of select="."/>
        </div>
    </xsl:template>
</xsl:stylesheet>
