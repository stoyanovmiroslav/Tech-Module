const Report = require('../models/Report');

module.exports = {
    index: (req, res) => {
        Report.find().then(reports => {
            return res.render('report/index', {'reports': reports});
        }).catch(err => {
            return res.send("error");
        });
    },
    createGet: (req, res) => {//
       res.render('report/create');
        return null;
    },
    createPost: (req, res) => {
        let report = req.body;
        Report.create(report).then(report => {
            res.redirect("/");
        }).catch(err => {
            report.error = 'Cannot create film.';
            res.render('report/create', report);
        });
        return null;
    },
    detailsGet: (req, res) => {
        let id = req.params.id;
        Report.findById(id).then(report => {
                if (report === null) {
                    res.redirect('/');
                    return;
                }
                res.render("report/details", report);
        });
    },
    deleteGet: (req, res) => {
        let id = req.params.id;
        Report.findById(id).then(report => {
            if (report) {
                return res.render('report/delete', report);
            }
            else {
                return res.redirect('/');
            }
        }).catch(err => res.redirect('/'));
    },
    deletePost: (req, res) => {
        let id = req.params.id;
        Report.findByIdAndRemove(id).then(data => {
            res.redirect('/');
        }).catch(err => res.redirect('/'));
    }
};