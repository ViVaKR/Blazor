export class CodeModel {
    _id;
    _title;
    _content;
    _createdAt;
    constructor(id, title, content) {
        this._id = id;
        this._title = title;
        this._content = content;
        this._createdAt = new Date();
    }
    get id() {
        return this._id;
    }
    get title() {
        return this._title;
    }
    set title(value) {
        this._title = value;
    }
    get content() {
        return this._content;
    }
    set content(value) {
        this._content = value;
    }
    get createdAt() {
        return this._createdAt;
    }
    toString() {
        return `CodeModel: ${this._id} - ${this._title}`;
    }
    static getCurrentInstance() {
        return window.currentInstance || null;
    }
    static create(id, title, content) {
        const instance = new CodeModel(id, title, content);
        window.currentInstance = instance;
        return instance;
    }
}
//# sourceMappingURL=code.js.map